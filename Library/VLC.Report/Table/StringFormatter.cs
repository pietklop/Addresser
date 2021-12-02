namespace VLC.Report.Table
{
    public class StringFormatter
    {
        private readonly DocBuilder docBuilder;

        public StringFormatter(DocBuilder docBuilder)
        {
            this.docBuilder = docBuilder;
        }

        public string LimitString(string data, double? maxWidth, bool addDots = true)
        {         
            if (!maxWidth.HasValue || StringWidth(data) <= maxWidth) return data;

            string dots = addDots ? ".." : "";
            while (StringWidth($"{data}{dots}") > maxWidth)
                data = data.Substring(0, data.Length - 1);

            return $"{data}{dots}";
        }

        private double StringWidth(string data) => 
            docBuilder.CurrentGfx.MeasureString(data, docBuilder.CurrentFont).Width;
    }
}