namespace DAL.Entities
{
    public class StickerConfig : Entity
    {
        public string Name { get; set; }
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public int RowOffset { get; set; }
        public int ColumnOffset { get; set; }
        public int RowPitch{ get; set; }
        public int ColumnPitch{ get; set; }
        public int FontSize { get; set; }
        public bool IsDefault { get; set; }
    }
}