using Core;

namespace Messages.UI
{
    public static class FamilyHelper
    {
        public static string DisplayName(string nameOverride, Title title, string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(nameOverride)) return nameOverride;
            string prefix = title == Title.FirstName ? firstName : $"{title}.";
            return $"{prefix} {lastName}";
        }
    }
}