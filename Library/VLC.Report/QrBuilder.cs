using System.Drawing;
using QRCoder;

namespace VLC.Report
{
    public static class QrBuilder
    {
        /// <summary>
        /// Generates a qr-code bitmap
        /// </summary>
        /// <param name="code"></param>
        /// <param name="pixPerModule">Number of pixels per module (sub square)</param>
        /// <param name="level">Redundancy level, increasing order (L, M, Q, H)</param>
        /// <remarks>
        /// Smallest size QR (21x21) can contain:
        /// Level L: 17 characters
        /// Level M: 14 characters
        /// Level Q: 11 characters
        /// Level H:  7 characters
        /// See: https://www.qrcode.com/en/about/version.html
        /// </remarks>
        public static Bitmap Generate(string code, int pixPerModule = 4, QRCodeGenerator.ECCLevel level = QRCodeGenerator.ECCLevel.H)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(code, level);
            var qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(pixPerModule);
        }
    }
}