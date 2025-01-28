using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarageManager.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DevFlow_Adress_280125 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Tbl_Customers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Tbl_Customers");
        }
    }
}
