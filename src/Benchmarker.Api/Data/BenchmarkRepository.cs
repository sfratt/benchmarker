using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Benchmarker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Benchmarker.Api.Data
{
    public class BenchmarkRepository : IBenchmarkRepository
    {
        private readonly BenchmarkContext _context;

        public BenchmarkRepository(BenchmarkContext context) => _context = context;

        public Task CreateBenchmarkAsync(Benchmark benchmark)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBenchmarkAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Benchmark> GetBenchmarkAsync(int id) => await _context.Benchmarks.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<Benchmark>> GetBenchmarksAsync() => await _context.Benchmarks.ToListAsync();

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateBenchmarkAsync(Benchmark benchmark)
        {
            throw new System.NotImplementedException();
        }
    }
}