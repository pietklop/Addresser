using System.ComponentModel;

namespace Messages.UI.Overview
{
    public class StickerConfigViewModel
    {
        [ColumnCellsUnderline]
        public string Name { get; set; }
        [DisplayName("Rows")]
        public int RowCount { get; set; }
        [DisplayName("Cols")]
        public int ColumnCount { get; set; }
        [DisplayName("Used")]
        public bool IsDefault { get; set; }
    }
}