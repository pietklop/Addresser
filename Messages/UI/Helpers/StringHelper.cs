namespace Messages.UI.Helpers
{
    public static class StringHelper
    {
        public static string Limit(this string text, int maxChars)
        {
            if (text.Length <= maxChars) return text;
            return $"{text.Substring(0, maxChars - 1)}..";
        }
    }
}