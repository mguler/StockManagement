using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagement.Data.DataContext.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "StockManagement");

            migrationBuilder.CreateTable(
                name: "CurrentAccount",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialCode",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasureUnit",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAlertLevel",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlertMessage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAlertLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockCard",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MaterialCodeId = table.Column<int>(type: "int", nullable: false),
                    MeasureUnitId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockConsumptionType",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockConsumptionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockSupplementType",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockSupplementType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockImage",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockCardId = table.Column<int>(type: "int", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockImage_StockCard_StockCardId",
                        column: x => x.StockCardId,
                        principalSchema: "StockManagement",
                        principalTable: "StockCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockBalance",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackingNumber = table.Column<int>(type: "int", nullable: false),
                    Inbound = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Outbound = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockCardId = table.Column<int>(type: "int", nullable: false),
                    StockTransactionId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockBalance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockBalance_StockCard_StockCardId",
                        column: x => x.StockCardId,
                        principalSchema: "StockManagement",
                        principalTable: "StockCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockBalance_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalSchema: "StockManagement",
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockTransaction",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockCardId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    OutboundCurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    InboundCurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    TrackingNumber = table.Column<int>(type: "int", nullable: false),
                    Inbound = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Outbound = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockTransaction_CurrentAccount_InboundCurrentAccountId",
                        column: x => x.InboundCurrentAccountId,
                        principalSchema: "StockManagement",
                        principalTable: "CurrentAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StockTransaction_CurrentAccount_OutboundCurrentAccountId",
                        column: x => x.OutboundCurrentAccountId,
                        principalSchema: "StockManagement",
                        principalTable: "CurrentAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StockTransaction_StockCard_StockCardId",
                        column: x => x.StockCardId,
                        principalSchema: "StockManagement",
                        principalTable: "StockCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalSchema: "StockManagement",
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockValor",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrackingNumber = table.Column<int>(type: "int", nullable: false),
                    Inbound = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Outbound = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockCardId = table.Column<int>(type: "int", nullable: false),
                    StockTransactionId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockValor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockValor_StockCard_StockCardId",
                        column: x => x.StockCardId,
                        principalSchema: "StockManagement",
                        principalTable: "StockCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockValor_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalSchema: "StockManagement",
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWarehouseAssignment",
                schema: "StockManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: true),
                    WarehouseId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWarehouseAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWarehouseAssignment_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "StockManagement",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWarehouseAssignment_User_UserId1",
                        column: x => x.UserId1,
                        principalSchema: "StockManagement",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserWarehouseAssignment_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalSchema: "StockManagement",
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWarehouseAssignment_Warehouse_WarehouseId1",
                        column: x => x.WarehouseId1,
                        principalSchema: "StockManagement",
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockBalance_StockCardId",
                schema: "StockManagement",
                table: "StockBalance",
                column: "StockCardId");

            migrationBuilder.CreateIndex(
                name: "IX_StockBalance_WarehouseId",
                schema: "StockManagement",
                table: "StockBalance",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_StockImage_StockCardId",
                schema: "StockManagement",
                table: "StockImage",
                column: "StockCardId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_InboundCurrentAccountId",
                schema: "StockManagement",
                table: "StockTransaction",
                column: "InboundCurrentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_OutboundCurrentAccountId",
                schema: "StockManagement",
                table: "StockTransaction",
                column: "OutboundCurrentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_StockCardId",
                schema: "StockManagement",
                table: "StockTransaction",
                column: "StockCardId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_WarehouseId",
                schema: "StockManagement",
                table: "StockTransaction",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_StockValor_StockCardId",
                schema: "StockManagement",
                table: "StockValor",
                column: "StockCardId");

            migrationBuilder.CreateIndex(
                name: "IX_StockValor_WarehouseId",
                schema: "StockManagement",
                table: "StockValor",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWarehouseAssignment_UserId",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWarehouseAssignment_UserId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserWarehouseAssignment_WarehouseId",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWarehouseAssignment_WarehouseId1",
                schema: "StockManagement",
                table: "UserWarehouseAssignment",
                column: "WarehouseId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialCode",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "MeasureUnit",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockAlertLevel",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockBalance",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockConsumptionType",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockImage",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockSupplementType",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockTransaction",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockValor",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "UserWarehouseAssignment",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "CurrentAccount",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "StockCard",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "User",
                schema: "StockManagement");

            migrationBuilder.DropTable(
                name: "Warehouse",
                schema: "StockManagement");
        }
    }
}
