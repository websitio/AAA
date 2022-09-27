using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Services.Migrations
{
    public partial class CostAmountEntityCostCatFKremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts");

            migrationBuilder.AlterColumn<int>(
                name: "CostCategoryId",
                table: "CostAmounts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts",
                column: "CostCategoryId",
                principalTable: "CostCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts");

            migrationBuilder.AlterColumn<int>(
                name: "CostCategoryId",
                table: "CostAmounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts",
                column: "CostCategoryId",
                principalTable: "CostCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
