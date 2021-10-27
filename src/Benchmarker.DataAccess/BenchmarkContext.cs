using Benchmarker.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Benchmarker.DataAccess
{
    public class BenchmarkContext : DbContext
    {
        public BenchmarkContext(DbContextOptions<BenchmarkContext> options) : base(options) { }

        public DbSet<Benchmark>? Benchmarks { get; set; }
    }
}