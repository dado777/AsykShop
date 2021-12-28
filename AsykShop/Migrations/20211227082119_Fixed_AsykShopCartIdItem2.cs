using Microsoft.EntityFrameworkCore.Migrations;

namespace AsykShop.Migrations
{
    public partial class Fixed_AsykShopCartIdItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asyk_Category_CategoryId",
                table: "Asyk");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Asyk",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Asyk_CategoryId",
                table: "Asyk",
                newName: "IX_Asyk_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Asyk_Category_CategoryID",
                table: "Asyk",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asyk_Category_CategoryID",
                table: "Asyk");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Asyk",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Asyk_CategoryID",
                table: "Asyk",
                newName: "IX_Asyk_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asyk_Category_CategoryId",
                table: "Asyk",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
