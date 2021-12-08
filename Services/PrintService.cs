using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Core;
using Messages.UI.Dto;
using PdfSharp.Drawing;
using VLC.Report;

namespace Services
{
    public class PrintService
    {
        private readonly Settings settings;

        public PrintService(Settings settings)
        {
            this.settings = settings;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public void PrintPreview(List<FamilyDto> famList, StickerConfigDto stickerConfig, int nStickersToSkip = 0)
        {
            if (stickerConfig == null) throw new Exception($"{nameof(stickerConfig)} can not be null");
            var doc = CreatePrint(famList, stickerConfig, nStickersToSkip);
            string savePath = Path.ChangeExtension(settings.DbFileNamePath, "pdf");

            doc.Save("", savePath);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(savePath) { UseShellExecute = true };
            p.Start();
        }

        private DocBuilder CreatePrint(List<FamilyDto> famList, StickerConfigDto stickerConfig, int nStickersToSkip)
        {
            using var doc = new DocBuilder();

            doc.SetFont(new XFont("Arial", stickerConfig.FontSize));

            int i = 0;
            while (true)
            {
                for (int y = 0; y < stickerConfig.RowCount; y++)
                {
                    for (int x = 0; x < stickerConfig.ColumnCount; x++)
                    {
                        if (i >= nStickersToSkip)
                        {
                            doc.SetCurrentYPos(stickerConfig.RowOffset + y * stickerConfig.RowPitch);
                            var left = stickerConfig.ColumnOffset + x * stickerConfig.ColumnPitch;
                            DrawFamily(doc, famList[i - nStickersToSkip], left);
                        }   
                        i++;
                        if (i-nStickersToSkip >= famList.Count) return doc;
                    }
                }
                doc.NewPage();
            }
        }

        private void DrawFamily(DocBuilder doc, FamilyDto fam, int left)
        {
            doc.DrawString(fam.DisplayName(), x: left);
            doc.DrawString(fam.Street, x: left);
            doc.DrawString($"{fam.ZipCode} {fam.City}", x: left);
        }
    }
}