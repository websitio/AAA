using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Services.Migrations
{
    public partial class RenamedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Costs_Categories_CostCategoryId",
                table: "Costs");

            migrationBuilder.DropIndex(
                name: "IX_Costs_CostCategoryId",
                table: "Costs");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Costs",
                newName: "CostAmount");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Costs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Costs_CategoryId",
                table: "Costs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Costs_Categories_CategoryId",
                table: "Costs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Costs_Categories_CategoryId",
                table: "Costs");

            migrationBuilder.DropIndex(
                name: "IX_Costs_CategoryId",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Costs");

            migrationBuilder.RenameColumn(
                name: "CostAmount",
                table: "Costs",
                newName: "Cost");

            migrationBuilder.CreateIndex(
                name: "IX_Costs_CostCategoryId",
                table: "Costs",
                column: "CostCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Costs_Categories_CostCategoryId",
                table: "Costs",
                column: "CostCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
