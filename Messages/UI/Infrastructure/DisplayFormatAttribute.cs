using System;

namespace Messages.UI.Infrastructure
{
    public class DisplayFormatAttribute : Attribute
    {
        public DisplayFormatAttribute(string format)
        {
            Format = format;
        }
        public string Format { get; set; }
    }
}