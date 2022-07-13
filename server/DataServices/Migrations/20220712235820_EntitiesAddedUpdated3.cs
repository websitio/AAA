using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.DataServices.Migrations
{
    public partial class EntitiesAddedUpdated3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmount_UserCategory_UserCategoryId",
                table: "CostAmount");

            migrationBuilder.AlterColumn<int>(
                name: "UserCategoryId",
                table: "CostAmount",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CostAmount",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CostAmount",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmount_UserCategory_UserCategoryId",
                table: "CostAmount",
                column: "UserCategoryId",
                principalTable: "UserCategory",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostAmount_UserCategory_UserCategoryId",
                table: "CostAmount");

            migrationBuilder.AlterColumn<int>(
                name: "UserCategoryId",
                table: "CostAmount",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CostAmount",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CostAmount",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CostAmount_UserCategory_UserCategoryId",
                table: "CostAmount",
                column: "UserCategoryId",
                principalTable: "UserCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
