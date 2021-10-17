using Microsoft.EntityFrameworkCore.Migrations;

namespace Benchmarker.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benchmarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpuUtilization = table.Column<int>(type: "int", nullable: false),
                    NetworkIn = table.Column<int>(type: "int", nullable: false),
                    NetworkOut = table.Column<int>(type: "int", nullable: false),
                    MemoryUtilization = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benchmarks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Benchmarks");
        }
    }
}
