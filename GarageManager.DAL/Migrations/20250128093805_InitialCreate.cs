using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarageManager.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LisencePlateNumber = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialSecurityNumber = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Customers_Tbl_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Tbl_Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Cars_CustomerId",
                table: "Tbl_Cars",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Customers_CarId",
                table: "Tbl_Customers",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Cars_Tbl_Customers_CustomerId",
                table: "Tbl_Cars",
                column: "CustomerId",
                principalTable: "Tbl_Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Cars_Tbl_Customers_CustomerId",
                table: "Tbl_Cars");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Tbl_Customers");

            migrationBuilder.DropTable(
                name: "Tbl_Cars");
        }
    }
}
