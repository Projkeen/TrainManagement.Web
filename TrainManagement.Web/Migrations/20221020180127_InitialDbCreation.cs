using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainManagement.Web.Migrations
{
    public partial class InitialDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    TrainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalDestination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainLength = table.Column<int>(type: "int", nullable: true),
                    AverageAmountOfCarriagesPerDay = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.TrainId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trains");
        }
    }
}
