using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkName = table.Column<string>(maxLength: 30, nullable: false),
                    ParkLocation = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkLocation", "ParkName" },
                values: new object[] { 1, "A 1200-mile area of land best known for its amazing waterfalls and rock formations.", "Sierra-Nevada Mountains, California, USA.", "Yosemite National Park" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkLocation", "ParkName" },
                values: new object[] { 2, "Decommissioned fort on the Puget Sound, home to a vast array of bunkers and museums.", "Port Townsand, Washington, USA.", "Fort Wardon State Park" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkLocation", "ParkName" },
                values: new object[] { 3, "A massive lake that lies in the remnants of the ancient volcano Mazama. The ninth deepest lake in the world.", "Southern Oregon, USA", "Crater Lake National Park" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
