using Messages.UI.Infrastructure;

namespace Messages.UI.Overview
{
    public class FamilyViewModel
    {
        public string DisplayName { get; set; }
        [ColumnCellsUnderline]
        public string FirstName { get; set; }
        [ColumnCellsUnderline]
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}