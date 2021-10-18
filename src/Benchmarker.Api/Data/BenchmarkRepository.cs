using System.Collections.Generic;
using System.Linq;
using Benchmarker.Api.Models;

namespace Benchmarker.Api.Data
{
    public class BenchmarkRepository : IBenchmarkRepository
    {
        private readonly BenchmarkContext _context;

        public BenchmarkRepository(BenchmarkContext context) => _context = context;

        public void CreateBenchmark(Benchmark benchmark)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBenchmark(Benchmark benchmark)
        {
            throw new System.NotImplementedException();
        }

        public Benchmark GetBenchmarkById(int id) => _context.Benchmarks.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Benchmark> GetBenchmarks() => _context.Benchmarks.ToList();

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBenchmark(Benchmark benchmark)
        {
            throw new System.NotImplementedException();
        }
    }
}