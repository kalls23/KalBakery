using Microsoft.EntityFrameworkCore.Migrations;

namespace KalBakery.Migrations
{
    public partial class seedcakedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[] { 1, "Our famous Choco Cake!", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, "Chocolate Cake", 12.95m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[] { 2, "Our famous Vanilla Cake!", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, "Vanilla Cake", 10.95m });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "Name", "Price" },
                values: new object[] { 3, "Our famous strawberry garden to table cake!", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, "Strawberry Cake", 14.95m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3);
        }
    }
}
