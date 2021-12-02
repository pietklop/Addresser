using Messages.UI.Infrastructure;

namespace Messages.UI.Overview
{
    public class PrintListViewModel
    {
        [ColumnCellsUnderline]
        public string Name { get; set; }
        public int Count { get; set; }
    }
}