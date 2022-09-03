using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Services.Migrations
{
    public partial class SeptemberStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmount_UserCategory_UserCategoryId",
                table: "CostAmount");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategory_Users_AppUserId",
                table: "UserCategory");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCategory",
                table: "UserCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostAmount",
                table: "CostAmount");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CostAmount");

            migrationBuilder.RenameTable(
                name: "UserCategory",
                newName: "UserCategories");

            migrationBuilder.RenameTable(
                name: "CostAmount",
                newName: "CostAmounts");

            migrationBuilder.RenameIndex(
                name: "IX_UserCategory_AppUserId",
                table: "UserCategories",
                newName: "IX_UserCategories_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CostAmount_UserCategoryId",
                table: "CostAmounts",
                newName: "IX_CostAmounts_UserCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "UserCategories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCategoryId",
                table: "CostAmounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "CostAmounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCategories",
                table: "UserCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostAmounts",
                table: "CostAmounts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreateBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

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
                name: "FK_CostAmounts_UserCategories_UserCategoryId",
                table: "CostAmounts",
                column: "UserCategoryId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_AppUsers_AppUserId",
                table: "CostAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CostAmounts_UserCategories_UserCategoryId",
                table: "CostAmounts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_AppUsers_AppUserId",
                table: "UserCategories");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCategories",
                table: "UserCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostAmounts",
                table: "CostAmounts");

            migrationBuilder.DropIndex(
                name: "IX_CostAmounts_AppUserId",
                table: "CostAmounts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CostAmounts");

            migrationBuilder.RenameTable(
                name: "UserCategories",
                newName: "UserCategory");

            migrationBuilder.RenameTable(
                name: "CostAmounts",
                newName: "CostAmount");

            migrationBuilder.RenameIndex(
                name: "IX_UserCategories_AppUserId",
                table: "UserCategory",
                newName: "IX_UserCategory_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CostAmounts_UserCategoryId",
                table: "CostAmount",
                newName: "IX_CostAmount_UserCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "UserCategory",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "UserCategoryId",
                table: "CostAmount",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CostAmount",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCategory",
                table: "UserCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostAmount",
                table: "CostAmount",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: true),
                    UpdateBy = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmount_UserCategory_UserCategoryId",
                table: "CostAmount",
                column: "UserCategoryId",
                principalTable: "UserCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategory_Users_AppUserId",
                table: "UserCategory",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
