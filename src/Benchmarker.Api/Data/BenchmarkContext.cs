using Benchmarker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Benchmarker.Api.Data
{
    public class BenchmarkContext : DbContext
    {
        public BenchmarkContext(DbContextOptions<BenchmarkContext> options) : base(options) { }

        public DbSet<Benchmark>? Benchmarks { get; set; }
    }
}