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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CpuUtilization = table.Column<int>(type: "INTEGER", nullable: false),
                    NetworkIn = table.Column<int>(type: "INTEGER", nullable: false),
                    NetworkOut = table.Column<int>(type: "INTEGER", nullable: false),
                    MemoryUtilization = table.Column<double>(type: "REAL", nullable: false)
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
