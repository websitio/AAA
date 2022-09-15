using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Services.Migrations
{
    public partial class EntitiesNamesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_UserCategories_UserCategoryId",
                table: "CostAmounts");

            migrationBuilder.RenameColumn(
                name: "UserCategoryId",
                table: "CostAmounts",
                newName: "CostCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_CostAmounts_UserCategoryId",
                table: "CostAmounts",
                newName: "IX_CostAmounts_CostCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_UserCategories_CostCategoryId",
                table: "CostAmounts",
                column: "CostCategoryId",
                principalTable: "UserCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_UserCategories_CostCategoryId",
                table: "CostAmounts");

            migrationBuilder.RenameColumn(
                name: "CostCategoryId",
                table: "CostAmounts",
                newName: "UserCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_CostAmounts_CostCategoryId",
                table: "CostAmounts",
                newName: "IX_CostAmounts_UserCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_UserCategories_UserCategoryId",
                table: "CostAmounts",
                column: "UserCategoryId",
                principalTable: "UserCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
