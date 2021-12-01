using System.Collections.Generic;

namespace DAL.Entities
{
    public class PrintList : Entity
    {
        public string Name { get; set; }
        public ICollection<FamilyPrintListRelation> FamilyPrintListRelations { get; set; }
    }
}