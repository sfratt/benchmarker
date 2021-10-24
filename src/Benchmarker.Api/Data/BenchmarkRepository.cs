using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Benchmarker.Api.DataTransferObjects;
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

        public async Task<Benchmark> GetBenchmarkAsync(Guid id) => await _context.Benchmarks.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<string>> GetBenchmarksAsync(RequestForWorkload request)
        {
            List<string> benchmarks = new();
            switch (request.Metric!.ToLower())
            {
                case "cpu":
                    benchmarks = (
                        await _context.Benchmarks!
                            .Where(u => u.BenchmarkType == request.BenchmarkType)
                            .Select(x => x.CpuUtilization)
                            .ToListAsync()
                        ).ConvertAll<string>(x => x.ToString());
                    break;
                case "memory":
                    benchmarks = (await _context.Benchmarks!.Select(x => x.MemoryUtilization).ToListAsync())
                        .ConvertAll<string>(x => x.ToString());
                    break;
                default:
                    break;
            }
            return benchmarks;
        }

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