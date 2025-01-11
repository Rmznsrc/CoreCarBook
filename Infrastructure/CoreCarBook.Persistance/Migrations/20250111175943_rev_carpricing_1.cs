using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class rev_carpricing_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_CarPricings_CarPricingID1",
                table: "CarPricings");

            migrationBuilder.DropIndex(
                name: "IX_CarPricings_CarPricingID1",
                table: "CarPricings");

            migrationBuilder.DropColumn(
                name: "CarPricingID1",
                table: "CarPricings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarPricingID1",
                table: "CarPricings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarPricings_CarPricingID1",
                table: "CarPricings",
                column: "CarPricingID1");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_CarPricings_CarPricingID1",
                table: "CarPricings",
                column: "CarPricingID1",
                principalTable: "CarPricings",
                principalColumn: "CarPricingID");
        }
    }
}
