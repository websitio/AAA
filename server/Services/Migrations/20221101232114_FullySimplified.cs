using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Services.Migrations
{
    public partial class FullySimplified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_AppUsers_AppUserId",
                table: "CostAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CostCategories_AppUsers_AppUserId",
                table: "CostCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostCategories",
                table: "CostCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostAmounts",
                table: "CostAmounts");

            migrationBuilder.DropIndex(
                name: "IX_CostAmounts_AppUserId",
                table: "CostAmounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CostAmounts");

            migrationBuilder.RenameTable(
                name: "CostCategories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "CostAmounts",
                newName: "Costs");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_CostCategories_AppUserId",
                table: "Categories",
                newName: "IX_Categories_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CostAmounts_CostCategoryId",
                table: "Costs",
                newName: "IX_Costs_CostCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CostCategoryId",
                table: "Costs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Costs",
                table: "Costs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_AppUserId",
                table: "Categories",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Costs_Categories_CostCategoryId",
                table: "Costs",
                column: "CostCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_AppUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Costs_Categories_CostCategoryId",
                table: "Costs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Costs",
                table: "Costs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AppUsers");

            migrationBuilder.RenameTable(
                name: "Costs",
                newName: "CostAmounts");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CostCategories");

            migrationBuilder.RenameIndex(
                name: "IX_Costs_CostCategoryId",
                table: "CostAmounts",
                newName: "IX_CostAmounts_CostCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_AppUserId",
                table: "CostCategories",
                newName: "IX_CostCategories_AppUserId");

            migrationBuilder.AlterColumn<int>(
                name: "CostCategoryId",
                table: "CostAmounts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "CostAmounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostAmounts",
                table: "CostAmounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostCategories",
                table: "CostCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CostAmounts_AppUserId",
                table: "CostAmounts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_AppUsers_AppUserId",
                table: "CostAmounts",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmounts_CostCategories_CostCategoryId",
                table: "CostAmounts",
                column: "CostCategoryId",
                principalTable: "CostCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CostCategories_AppUsers_AppUserId",
                table: "CostCategories",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
