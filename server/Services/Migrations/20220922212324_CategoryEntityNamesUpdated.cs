using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Services.Migrations
{
    public partial class CategoryEntityNamesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_UserCategories_CostCategoryId",
                table: "CostAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_AppUsers_AppUserId",
                table: "UserCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCategories",
                table: "UserCategories");

            migrationBuilder.RenameTable(
                name: "UserCategories",
                newName: "CostCategories");

            migrationBuilder.RenameIndex(
                name: "IX_UserCategories_AppUserId",
                table: "CostCategories",
                newName: "IX_CostCategories_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostCategories",
                table: "CostCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts",
                column: "CostCategoryId",
                principalTable: "CostCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CostCategories_AppUsers_AppUserId",
                table: "CostCategories",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CostCategories_AppUsers_AppUserId",
                table: "CostCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostCategories",
                table: "CostCategories");

            migrationBuilder.RenameTable(
                name: "CostCategories",
                newName: "UserCategories");

            migrationBuilder.RenameIndex(
                name: "IX_CostCategories_AppUserId",
                table: "UserCategories",
                newName: "IX_UserCategories_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCategories",
                table: "UserCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_UserCategories_CostCategoryId",
                table: "CostAmounts",
                column: "CostCategoryId",
                principalTable: "UserCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_AppUsers_AppUserId",
                table: "UserCategories",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
