using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Add_StickerConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StickerConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    RowCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ColumnCount = table.Column<int>(type: "INTEGER", nullable: false),
                    RowOffset = table.Column<int>(type: "INTEGER", nullable: false),
                    ColumnOffset = table.Column<int>(type: "INTEGER", nullable: false),
                    RowPitch = table.Column<int>(type: "INTEGER", nullable: false),
                    ColumnPitch = table.Column<int>(type: "INTEGER", nullable: false),
                    FontSize = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StickerConfigs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StickerConfigs");
        }
    }
}
