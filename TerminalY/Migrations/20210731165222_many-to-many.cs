using Microsoft.EntityFrameworkCore.Migrations;

namespace TerminalY.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchesProduct",
                columns: table => new
                {
                    BranchesId = table.Column<int>(type: "int", nullable: false),
                    productsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchesProduct", x => new { x.BranchesId, x.productsId });
                    table.ForeignKey(
                        name: "FK_BranchesProduct_Branches_BranchesId",
                        column: x => x.BranchesId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchesProduct_Product_productsId",
                        column: x => x.productsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchesProduct_productsId",
                table: "BranchesProduct",
                column: "productsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchesProduct");
        }
    }
}
