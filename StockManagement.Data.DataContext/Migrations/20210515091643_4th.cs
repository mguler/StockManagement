using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagement.Data.DataContext.Migrations
{
    public partial class _4th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StockCard_MaterialCodeId",
                schema: "StockManagement",
                table: "StockCard",
                column: "MaterialCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockCard_MeasureUnitId",
                schema: "StockManagement",
                table: "StockCard",
                column: "MeasureUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockCard_MaterialCode_MaterialCodeId",
                schema: "StockManagement",
                table: "StockCard",
                column: "MaterialCodeId",
                principalSchema: "StockManagement",
                principalTable: "MaterialCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockCard_MeasureUnit_MeasureUnitId",
                schema: "StockManagement",
                table: "StockCard",
                column: "MeasureUnitId",
                principalSchema: "StockManagement",
                principalTable: "MeasureUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockCard_MaterialCode_MaterialCodeId",
                schema: "StockManagement",
                table: "StockCard");

            migrationBuilder.DropForeignKey(
                name: "FK_StockCard_MeasureUnit_MeasureUnitId",
                schema: "StockManagement",
                table: "StockCard");

            migrationBuilder.DropIndex(
                name: "IX_StockCard_MaterialCodeId",
                schema: "StockManagement",
                table: "StockCard");

            migrationBuilder.DropIndex(
                name: "IX_StockCard_MeasureUnitId",
                schema: "StockManagement",
                table: "StockCard");
        }
    }
}
