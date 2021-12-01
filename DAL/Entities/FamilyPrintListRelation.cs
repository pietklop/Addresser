namespace DAL.Entities
{
    public class FamilyPrintListRelation
    {
        public int FamilyId { get; set; }
        public Family Family { get; set; }
        public int PrintListId { get; set; }
        public PrintList PrintList { get; set; }
    }
}