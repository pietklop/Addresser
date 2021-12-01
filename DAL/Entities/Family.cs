using Core;
using JetBrains.Annotations;

namespace DAL.Entities
{
    public class Family : Entity
    {
        public Title Title { get; set; }
        [CanBeNull] public string NameOverride { get; set; }
        [CanBeNull] public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}