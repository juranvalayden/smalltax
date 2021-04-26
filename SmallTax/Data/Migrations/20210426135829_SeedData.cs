using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallTax.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxBrackets",
                columns: new[] { "Id", "Lower", "Rate", "Upper" },
                values: new object[,]
                {
                    { 1, 1m, 10m, 8350m },
                    { 2, 8351m, 15m, 33950m },
                    { 3, 33951m, 25m, 82250m },
                    { 4, 82251m, 28m, 171550m },
                    { 5, 171551m, 33m, 372950m },
                    { 6, 37951m, 35m, -1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxBrackets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxBrackets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxBrackets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxBrackets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxBrackets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxBrackets",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
