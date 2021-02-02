using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCardId = table.Column<string>(nullable: true),
                    CandyId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Candies_CandyId",
                        column: x => x.CandyId,
                        principalTable: "Candies",
                        principalColumn: "CandyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "\\Images\\thumbnails\\chocolateCandy-small.jpg", "\\Images\\chocolateCandy.jpg", "Assorted Chocolate Candy" });

            migrationBuilder.UpdateData(
                table: "Categires",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Chocolate Candy");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CandyId",
                table: "ShoppingCartItems",
                column: "CandyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "~\\Image\\thumbnails\\chocolateCandy-small.jpg", "~\\Images\\chocolateCandy.jpg", "Asssorted Chocolate Candy" });

            migrationBuilder.UpdateData(
                table: "Categires",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Choclate Candy");
        }
    }
}
