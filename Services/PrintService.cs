using System.Collections.Generic;
using System.Diagnostics;
using Messages.UI.Dto;
using PdfSharp.Drawing;
using VLC.Report;

namespace Services
{
    public class PrintService
    {
        public PrintService()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public void PrintPreview(List<FamilyDto> famList)
        {
            var doc = CreatePrint(famList);
            string savePath = @"c:\address.pdf";

            doc.Save("", savePath);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(savePath) { UseShellExecute = true };
            p.Start();
        }

        private DocBuilder CreatePrint(List<FamilyDto> famList)
        {
            using var doc = new DocBuilder();

            doc.SetFont(new XFont("Arial", 12));

            doc.MoveCurrentYPos(50);

            famList.ForEach(f => DrawFamily(doc, f, 50));

            return doc;
        }

        private void DrawFamily(DocBuilder doc, FamilyDto fam, int left)
        {
            doc.DrawString(fam.DisplayName(), x: left);
            doc.DrawString(fam.Street, x: left);
            doc.DrawString($"{fam.ZipCode} {fam.City}", x: left);
            doc.MoveCurrentYPos(20);
        }
    }
}