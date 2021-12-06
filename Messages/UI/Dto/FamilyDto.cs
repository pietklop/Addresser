using Core;
using JetBrains.Annotations;

namespace Messages.UI.Dto
{
    public class FamilyDto
    {
        public int Id { get; set; }
        public Title Title { get; set; }
        [CanBeNull] public string NameOverride { get; set; }
        [CanBeNull] public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";

        public string DisplayName() => FamilyHelper.DisplayName(NameOverride, Title, FirstName, LastName);
    }
}