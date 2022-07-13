using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.DataServices.Migrations
{
    public partial class EntitiesAddedUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategory_Users_AppUserId",
                table: "UserCategory");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "UserCategory",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategory_Users_AppUserId",
                table: "UserCategory",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategory_Users_AppUserId",
                table: "UserCategory");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "UserCategory",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategory_Users_AppUserId",
                table: "UserCategory",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
