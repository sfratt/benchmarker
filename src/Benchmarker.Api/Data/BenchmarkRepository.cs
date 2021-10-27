using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Benchmarker.Domain.DataTransferObjects;
using Benchmarker.Domain.Models;
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
            bool dataType;
            if (request.DataType.ToLower().Equals("training"))
            {
                dataType = true;
            }
            else if (request.DataType.ToLower().Equals("testing"))
            {
                dataType = false;
            }
            else
            {
                throw new ArgumentException("Data type is neither training nor testing");
            }

            List<Benchmark> benchmarks = await _context.Benchmarks!
                            .Where(a => a.BenchmarkType == request.BenchmarkType)
                            .Where(u => u.IsTrainingData == dataType)
                            .ToListAsync();
            List<string> metrics = new();
            switch (request.Metric.ToLower())
            {
                case "cpu":
                    metrics = benchmarks
                            .Select(x => x.CpuUtilization)
                            .ToList()
                            .ConvertAll<string>(x => x.ToString());
                    break;
                case "networkin":
                    metrics = benchmarks
                            .Select(x => x.NetworkIn)
                            .ToList()
                            .ConvertAll<string>(x => x.ToString());
                    break;
                case "networkout":
                    metrics = benchmarks
                            .Select(x => x.NetworkOut)
                            .ToList()
                            .ConvertAll<string>(x => x.ToString());
                    break;
                case "memory":
                    metrics = benchmarks
                            .Select(x => x.MemoryUtilization)
                            .ToList()
                            .ConvertAll<string>(x => x.ToString());
                    break;
                default:
                    break;
            }
            return metrics;
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