using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Add_FamilyPrintListRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrintLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyPrintListRelation",
                columns: table => new
                {
                    FamilyId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrintListId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyPrintListRelation", x => new { x.FamilyId, x.PrintListId });
                    table.ForeignKey(
                        name: "FK_FamilyPrintListRelation_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyPrintListRelation_PrintLists_PrintListId",
                        column: x => x.PrintListId,
                        principalTable: "PrintLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FamilyPrintListRelation_PrintListId",
                table: "FamilyPrintListRelation",
                column: "PrintListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FamilyPrintListRelation");

            migrationBuilder.DropTable(
                name: "PrintLists");
        }
    }
}
