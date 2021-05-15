using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagement.Data.DataContext.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockCardId",
                schema: "StockManagement",
                table: "StockAlertLevel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StockAlertLevel_StockCardId",
                schema: "StockManagement",
                table: "StockAlertLevel",
                column: "StockCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockAlertLevel_StockCard_StockCardId",
                schema: "StockManagement",
                table: "StockAlertLevel",
                column: "StockCardId",
                principalSchema: "StockManagement",
                principalTable: "StockCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockAlertLevel_StockCard_StockCardId",
                schema: "StockManagement",
                table: "StockAlertLevel");

            migrationBuilder.DropIndex(
                name: "IX_StockAlertLevel_StockCardId",
                schema: "StockManagement",
                table: "StockAlertLevel");

            migrationBuilder.DropColumn(
                name: "StockCardId",
                schema: "StockManagement",
                table: "StockAlertLevel");
        }
    }
}
