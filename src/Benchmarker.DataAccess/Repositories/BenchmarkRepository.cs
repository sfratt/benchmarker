using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Benchmarker.Domain.DataTransferObjects;
using Benchmarker.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Benchmarker.DataAccess.Repositories
{
    public class BenchmarkRepository : IBenchmarkRepository
    {
        private readonly BenchmarkContext _context;

        public BenchmarkRepository(BenchmarkContext context) => _context = context;

        public Task CreateBenchmarkAsync(Benchmark benchmark)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBenchmarkAsync(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Benchmark> GetBenchmarkAsync(Guid id) => await _context.Benchmarks.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<string>> GetBenchmarksAsync(RequestForWorkload request)
        {
            List<string> metrics = new();
            bool dataType;
            switch (request.DataType.ToLower())
            {
                case "training":
                    dataType = true;
                    break;
                case "testing":
                    dataType = false;
                    break;
                default:
                    return metrics;
            }

            List<Benchmark> benchmarks = await _context.Benchmarks!
                            .Where(a => a.BenchmarkType == request.BenchmarkType.ToLower())
                            .Where(u => u.IsTrainingData == dataType)
                            .ToListAsync();
            if (!benchmarks.Any()) return metrics;

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
                    return metrics;
            }

            var numberOfSamples = metrics.Count;
            var numberOfBatches = numberOfSamples / request.BatchUnit;
            var startIndex = request.BatchId * request.BatchUnit;
            var endIndex = request.BatchUnit * request.BatchSize;

            return metrics.GetRange(startIndex, endIndex);
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