using System.Drawing;
using System.IO;
using PdfSharp.Drawing;

namespace VLC.Report
{
    public static class BitmapHelper
    {
        private static double PixToPoint(int pix) { return pix * (double)72 / 96; }

        public static double HeightPoints(this Bitmap bmp)
        {
            return PixToPoint(bmp.Height);
        }

        public static double WidthPoints(this Bitmap bmp)
        {
            return PixToPoint(bmp.Width);
        }

        public static XImage ToXImage(this Bitmap bmp)
        {
            var stream = new MemoryStream();
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);

            return XImage.FromStream(stream);
        }
    }
}