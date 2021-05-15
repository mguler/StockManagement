using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagement.Data.DataContext.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWarehouseAssignment_User_UserId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWarehouseAssignment_Warehouse_WarehouseId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment");

            migrationBuilder.DropIndex(
                name: "IX_UserWarehouseAssignment_UserId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment");

            migrationBuilder.DropIndex(
                name: "IX_UserWarehouseAssignment_WarehouseId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment");

            migrationBuilder.DropColumn(
                name: "UserId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment");

            migrationBuilder.DropColumn(
                name: "WarehouseId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserWarehouseAssignment_UserId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserWarehouseAssignment_WarehouseId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "WarehouseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserWarehouseAssignment_User_UserId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "UserId1",
                principalSchema: "StockManagement",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWarehouseAssignment_Warehouse_WarehouseId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "WarehouseId1",
                principalSchema: "StockManagement",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
