using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlamCarProject.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Center",
                columns: table => new
                {
                    CenterNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    OpeningDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.CenterNo);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "SalePerson",
                columns: table => new
                {
                    SalePersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CenterNo = table.Column<int>(nullable: false),
                    CentersCenterNo = table.Column<int>(nullable: true),
                    isSenior = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePerson", x => x.SalePersonId);
                    table.ForeignKey(
                        name: "FK_SalePerson_Center_CentersCenterNo",
                        column: x => x.CentersCenterNo,
                        principalTable: "Center",
                        principalColumn: "CenterNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarSale",
                columns: table => new
                {
                    CarSaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    SalePersonId = table.Column<int>(nullable: false),
                    AgreedAmount = table.Column<double>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSale", x => x.CarSaleId);
                    table.ForeignKey(
                        name: "FK_CarSale_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarSale_SalePerson_SalePersonId",
                        column: x => x.SalePersonId,
                        principalTable: "SalePerson",
                        principalColumn: "SalePersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarSale_CustomerId",
                table: "CarSale",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CarSale_SalePersonId",
                table: "CarSale",
                column: "SalePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SalePerson_CentersCenterNo",
                table: "SalePerson",
                column: "CentersCenterNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarSale");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "SalePerson");

            migrationBuilder.DropTable(
                name: "Center");
        }
    }
}
