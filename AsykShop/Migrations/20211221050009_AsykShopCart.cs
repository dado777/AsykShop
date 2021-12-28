using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsykShop.Migrations
{
    public partial class AsykShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsykShopCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<int>(nullable: false),
                    AsykShopCartId = table.Column<string>(nullable: true),
                    AsyktarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsykShopCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsykShopCartItem_Asyk_AsyktarId",
                        column: x => x.AsyktarId,
                        principalTable: "Asyk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsykShopCartItem_AsyktarId",
                table: "AsykShopCartItem",
                column: "AsyktarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsykShopCartItem");
        }
    }
}
