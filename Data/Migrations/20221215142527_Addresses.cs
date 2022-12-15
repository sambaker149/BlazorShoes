using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorShoes.Data.Migrations
{
    public partial class Addresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    HouseName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    RoadName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostTown = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
