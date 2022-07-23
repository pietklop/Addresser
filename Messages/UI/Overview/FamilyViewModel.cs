using System.ComponentModel;
using Messages.UI.Infrastructure;

namespace Messages.UI.Overview
{
    public class FamilyViewModel
    {
        [DisplayName("Display name")]
        [Description("The name will be printed like shown in this column")]
        public string DisplayName { get; set; }
        [DisplayName("First name")]
        [ColumnCellsUnderline]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        [ColumnCellsUnderline]
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}