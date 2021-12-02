using System;
using System.Collections.Generic;

namespace VLC.Report.Table
{
    /// <summary>
    /// This class is able to draw a table by given table data
    /// </summary>
    public class TableBuilder
    {
        private readonly DocBuilder doc;

        public TableBuilder(DocBuilder docBuilder)
        {
            doc = docBuilder;
        }

        public void DrawTable(TableData tableData, double? x = null)
        {
            tableData.CalculateColumnPositions(x);
            foreach (var textRow in tableData.TextRows)
                DrawTableLine(tableData.ColumnDefinitions, textRow, tableData.AdditionalRowHeight);
        }

        private void DrawTableLine(List<ColumnDefinition> columnDefs, string[] textRow, double additionalRowHeight)
        {
            double rowHeight = DetermineRowHeight(columnDefs, textRow);
            if (doc.ReachedPageEnd(doc.CurrentY + rowHeight)) doc.NewPage();
            double y = doc.CurrentY;

            for (int i = 0; i < columnDefs.Count; i++)
            {
                if (i >= textRow.Length) break;
                if (textRow[i] == null) continue;
                DrawTableField(columnDefs[i], textRow[i], y, rowHeight);
            }

            y += rowHeight + additionalRowHeight;
            doc.SetCurrentYPos(y);
            doc.ProcessNewPage();
        }

        private void DrawTableField(ColumnDefinition columnDef, string text, double y, double rowHeight)
        {
            double XPos()
            {
                text = doc.LimitString(text, columnDef.Width);
                var size = doc.CurrentGfx.MeasureString(text, doc.CurrentFont);
                if (rowHeight > size.Height) y += rowHeight / 2;
                switch (columnDef.Alignment)
                {
                    case Alignment.Left:
                        return columnDef.XPos;
                    case Alignment.Center:
                        return columnDef.Width / 2 - size.Width / 2 + columnDef.XPos;
                    case Alignment.Right:
                        return columnDef.XPos + columnDef.Width - size.Width;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            switch (columnDef.DataType)
            {
                case DataType.String:
                    doc.DrawString(text, x: XPos(), y: y, maxWidth: columnDef.Width);
                    break;
                case DataType.QrCode:
                    doc.DrawQrCode(text, columnDef.XPos + columnDef.Width / 2, y + 20, Alignment.Center, columnDef.Width);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private double DetermineRowHeight(List<ColumnDefinition> columnDefs, string[] textRow)
        {
            double maxHeight = 0;
            for (int i = 0; i < columnDefs.Count; i++)
            {
                if (i >= textRow.Length) break;
                switch (columnDefs[i].DataType)
                {
                    case DataType.String:
                        if (doc.CurrentFontHeight > maxHeight)
                            maxHeight = doc.CurrentFontHeight;
                        break;
                    case DataType.QrCode:
                        if (textRow[i] == null) continue;
                        double height = DetermineQrCodeHeight(textRow[i]);
                        if (height > maxHeight) maxHeight = height;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return maxHeight;
        }

        /// <remarks>This could be calculated but this is the easiest option</remarks>
        private double DetermineQrCodeHeight(string code) => QrBuilder.Generate(code).HeightPoints();
    }
}