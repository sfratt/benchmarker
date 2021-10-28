using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Benchmarker.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benchmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CpuUtilization = table.Column<int>(type: "int", nullable: false),
                    NetworkIn = table.Column<int>(type: "int", nullable: false),
                    NetworkOut = table.Column<int>(type: "int", nullable: false),
                    MemoryUtilization = table.Column<double>(type: "float", nullable: false),
                    BenchmarkType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTrainingData = table.Column<bool>(type: "bit", nullable: false),
                    SampleId = table.Column<int>(type: "int", nullable: false)
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
