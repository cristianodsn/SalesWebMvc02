using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc02.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salesRecord_Seller_SellerId",
                table: "salesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_salesRecord",
                table: "salesRecord");

            migrationBuilder.RenameTable(
                name: "salesRecord",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_salesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "salesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "salesRecord",
                newName: "IX_salesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesRecord",
                table: "salesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_salesRecord_Seller_SellerId",
                table: "salesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
