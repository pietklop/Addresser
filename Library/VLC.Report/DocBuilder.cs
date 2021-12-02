using System;
using System.Drawing;
using System.IO;
using log4net;
using PdfiumPrinter;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using VLC.Report.Table;
using PdfDocument = PdfSharp.Pdf.PdfDocument;

namespace VLC.Report
{
    public class DocBuilder : IDisposable
    {
        /// <summary>
        /// When true automatically add a new page when crossing bottom border
        /// </summary>
        public bool AutoAddPage { get; set; }
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private PdfDocument doc = new PdfDocument();
        private PdfPage currentPage;
        internal XGraphics CurrentGfx { get; private set; }
        internal XFont CurrentFont = new XFont("Arial", 10, XFontStyle.Bold);
        internal XSolidBrush CurrentBrush => new XSolidBrush(CurrentColor);
        internal XPen CurrentPen => new XPen(CurrentColor);
        internal XColor CurrentColor = XColors.Black;
        public double CurrentFontHeight => CurrentFont.GetHeight();

        public double CurrentX { get; private set; }
        public double CurrentY { get; private set; }

        private double sideMargin = 30;
        private double yMargin = 10;
        /// <summary>
        /// Workspace border
        /// </summary>
        public double LeftBorder => sideMargin;
        /// <summary>
        /// Workspace border
        /// </summary>
        public double RightBorder => currentPage.Width - sideMargin;
        /// <summary>
        /// Workspace border
        /// </summary>
        public double TopBorder => yMargin;

        /// <summary>
        /// Workspace border
        /// </summary>
        public double BottomBorder;
        public double Center => currentPage.Width / 2;
        /// <summary>
        /// Printable workspace
        /// </summary>
        public double WorkspaceWidth => RightBorder - LeftBorder;

        private StringFormatter stringFormatter;
        private TableBuilder tableBuilder;

        public DocBuilder() : this(true)
        {
        }

        public DocBuilder(bool autoAddPage)
        {
            AutoAddPage = autoAddPage;
            stringFormatter = new StringFormatter(this);
            tableBuilder = new TableBuilder(this);
            NewPage();
            BottomBorder = currentPage.Height - yMargin;
        }

        /// <param name="font"></param>
        /// <param name="autoAdjustYPos">Adjusts the (new line) y position regarding possible different font height</param>
        public void SetFont(XFont font, bool autoAdjustYPos = true)
        {
            if (autoAdjustYPos)
                CurrentY += font.GetHeight() - CurrentFontHeight;
            CurrentFont = font;
        }

        public void SetColor(XColor color) { CurrentColor = color; }

        #region Positioning
        public void SetCurrentPos(double x, double y)
        {
            SetCurrentXPos(x);
            SetCurrentYPos(y);
        }
        public void SetCurrentXPos(double x) { CurrentX = x; }
        public void SetCurrentYPos(double y) { CurrentY = y; }

        public void MoveCurrentPos(double x, double y)
        {
            MoveCurrentXPos(x);
            MoveCurrentYPos(y);
        }
        public void MoveCurrentXPos(double x) { CurrentX += x; }
        public void MoveCurrentYPos(double y) { CurrentY += y; }
        #endregion

        public void NewPage()
        {
            CurrentGfx?.Dispose();
            currentPage = doc.AddPage();
            CurrentGfx = XGraphics.FromPdfPage(currentPage);
            CurrentX = LeftBorder;
            CurrentY = yMargin + CurrentFontHeight;
        }

        public void DrawString(string data, XFont font = null, double? x = null, double? y = null, bool endLine = true, Alignment alignment = Alignment.Continue, double? maxWidth = null)
        {
            if (x.HasValue) SetCurrentXPos(x.Value);
            if (y.HasValue) SetCurrentYPos(y.Value);
            if (font != null) SetFont(font);

            // support new lines
            data = data == null ? "" : data.Replace("\r\n", "\n");
            var parts = data.Split('\n');

            if (parts.Length > 1)
            {
                foreach (string part in parts)
                    DrawString(part, alignment: alignment);
                return;
            }
            
            var size = CurrentGfx.MeasureString(data, CurrentFont);
            data = LimitString(data, maxWidth);

            switch (alignment)
            {
                case Alignment.Continue:
                    break;
                case Alignment.Left:
                    CurrentX = x ?? LeftBorder;
                    break;
                case Alignment.Center:
                    CurrentX = (x ?? Center) - size.Width / 2;
                    break;
                case Alignment.Right:
                    CurrentX = (x ?? RightBorder) - size.Width;
                    break;
            }

            CurrentGfx.DrawString(data, CurrentFont, CurrentBrush, new XPoint(CurrentX, CurrentY));
            if (endLine)
                CurrentY += size.Height;
            else
                CurrentX += size.Width;

            if (AutoAddPage) ProcessNewPage();
        }

        /// <summary>
        /// Add a new page if bottom border is crossed
        /// </summary>
        public void ProcessNewPage()
        {
            if (ReachedPageEnd())
                NewPage();
        }

        /// <summary>
        /// Draw a single line string without changing the current font and positions
        /// </summary>
        public void DrawStringUnaffected(string data, XFont font, double x, double y, Alignment alignment = Alignment.Left)
        {
            var previousFont = CurrentFont;
            double previousX = CurrentX;
            double previousY = CurrentY;

            bool memAutoAddPage = AutoAddPage;
            AutoAddPage = false;
            DrawString(data, font, x, y, alignment: alignment);
            AutoAddPage = memAutoAddPage;

            SetFont(previousFont);
            SetCurrentPos(previousX, previousY);
        }

        /// <summary>
        /// Limit the string to the given maxWidth
        /// </summary>
        public string LimitString(string data, double? maxWidth, bool addDots = true) => 
            stringFormatter.LimitString(data, maxWidth, addDots);

        public void DrawImage(Bitmap bmp, double? x = null, double? y = null, bool framed = false, Alignment alignment = Alignment.Continue)
        {
            double? DetermineX()
            {
                switch (alignment)
                {
                    case Alignment.Continue:
                        x ??= CurrentX;
                        break;
                    case Alignment.Left:
                        x ??= LeftBorder;
                        break;
                    case Alignment.Center:
                        x = (x ?? Center) - bmp.WidthPoints() / 2;
                        break;
                    case Alignment.Right:
                        x = (x ?? RightBorder) - bmp.WidthPoints();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(alignment), alignment, null);
                }

                return x;
            }

            x = DetermineX();

            if (!y.HasValue) y = CurrentY;
            CurrentGfx.DrawImage(bmp.ToXImage(), (int)x, (int)y);

            if (framed)
                CurrentGfx.DrawRectangle(CurrentPen, (int)x, (int)y, bmp.WidthPoints(), bmp.HeightPoints());
        }

        public void DrawQrCode(string code, double? x = null, double? y = null, Alignment alignment = Alignment.Left, double? maxWidth = null)
        {
            var bmpQr = QrBuilder.Generate(code);
            DrawQrCode(bmpQr, x, y, alignment, maxWidth);
        }

        public void DrawQrCode(Bitmap bmpQr, double? x = null, double? y = null, Alignment alignment = Alignment.Left, double? maxWidth = null)
        {
            if (maxWidth.HasValue && bmpQr.WidthPoints() > maxWidth) // qr-code does not fit
            {
                log.Warn($"Qr-code can not be displayed because width ({bmpQr.WidthPoints()}) is larger than given MaxWidth: {maxWidth}");
                DrawStringUnaffected("No fit!", new XFont("arial", 10, XFontStyle.Bold), x ?? CurrentX, (y ?? CurrentY) + bmpQr.HeightPoints() / 2, Alignment.Center);
            }
            else
                DrawImage(bmpQr, x, y, alignment: alignment);
        }

        /// <summary>
        /// Draw a horizontal line over the complete page
        /// </summary>
        /// <param name="lineWidth"></param>
        public void DrawHorizontalSeparator(double lineWidth = 3)
        {
            CurrentGfx.DrawLine(new XPen(CurrentColor, lineWidth), LeftBorder, CurrentY, RightBorder, CurrentY);
            MoveCurrentYPos(lineWidth);
        }

        public void DrawTable(TableData tableData, double? x = null)
        {
            bool memAutoAddPage = AutoAddPage;
            AutoAddPage = false;
            tableBuilder.DrawTable(tableData, x);
            AutoAddPage = memAutoAddPage;
        }

        /// <summary>
        /// Draw marker for testing purposes
        ///    x
        ///    |
        /// y --- y
        ///    |
        ///    x
        /// </summary>
        public void DrawTestMarker(double? x = null, double? y = null)
        {
            x ??= CurrentX;
            y ??= CurrentY;
            double length = 20;

            var xFont = new XFont("arial", 10);
            double fontHeight = xFont.GetHeight();
            DrawStringUnaffected($"{x:F1}", xFont, x.Value, y.Value - length, Alignment.Center);
            DrawStringUnaffected($"{x:F1}", xFont, x.Value, y.Value + length + fontHeight, Alignment.Center);
            DrawStringUnaffected($"{y:F1}", xFont, x.Value - length, y.Value + fontHeight / 2, Alignment.Right);
            DrawStringUnaffected($"{y:F1}", xFont, x.Value + length, y.Value + fontHeight / 2);

            var xPen = new XPen(XColors.Red);
            CurrentGfx.DrawLine(xPen, x.Value - length, y.Value, x.Value + length, y.Value);
            CurrentGfx.DrawLine(xPen, x.Value, y.Value - length, x.Value, y.Value + length);
        }

        public bool ReachedPageEnd(double? y = null)
        {
            return (y ?? CurrentY) >= BottomBorder;
        }

        /// <param name="includeTotalSuffix">Add: /total pages</param>
        public void DrawPageNumbers(bool includeTotalSuffix = false)
        {
            string suffix = includeTotalSuffix ? $"/{doc.PageCount}" : "";
            var font = new XFont("arial", 10);
            for (int page = 0; page < doc.PageCount; page++)
            {
                CurrentGfx?.Dispose();
                CurrentGfx = XGraphics.FromPdfPage(doc.Pages[page]);
                DrawString($"{page + 1}{suffix}", font, y: BottomBorder, alignment: Alignment.Center);
            }
        }

        /// <summary>
        /// Print the document
        /// </summary>
        /// <remarks>
        /// You can list the installed printers in cmd with the following command:
        /// 'wmic printer list brief'
        /// Take the string from the 'Name' column
        /// </remarks>
        /// <param name="printerName">null => default printer</param>
        public void Print(string printerName = null)
        {
            using var ms = new MemoryStream();
            doc.Save(ms, false);
            var printer = new PdfPrinter(printerName);
            log.Debug($"Print document with '{printerName ?? "null => default printer"}'");
//            printer.PageSettings.Landscape = true;
            printer.Print(ms);
        }

        public void Save(string filePath) => doc.Save(filePath);
        public void Save(string path, string fileName) => doc.Save(Path.Combine(path, fileName));

        public byte[] ToArray()
        {
            using MemoryStream memoryStream = new MemoryStream();
            doc.Save(memoryStream);
            return memoryStream.ToArray();
        }

        public void Dispose()
        {
            doc?.Dispose();
            CurrentGfx?.Dispose();
        }
    }
}