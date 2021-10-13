using System.Collections.Generic;
using Benchmarker.Api.Models;

namespace Benchmarker.Api.Data
{
    /// <summary>
    /// Class <c>InMemoryBenchmarkRepository</c> is a concrete implementation of the <c>IBenchmarkRepository</c> interface.
    /// Referenced <see href="https://www.c-sharpcorner.com/article/factory-method-design-pattern/">here</see>.
    /// </summary>
    /// <remarks>A persisted implementation will be developed later.</remarks>
    public class InMemoryBenchmarkRepository : IBenchmarkRepository
    {
        private List<Benchmark> benchmarks;

        public InMemoryBenchmarkRepository()
        {
            benchmarks = new()
            {
                new Benchmark()
                {
                    Id = 1,
                    CpuUtilization = 39,
                    NetworkIn = 199985900,
                    NetworkOut = 181947520,
                    MemoryUtilization = 68.09846248
                },
                new Benchmark()
                {
                    Id = 2,
                    CpuUtilization = 38,
                    NetworkIn = 197149929,
                    NetworkOut = 178799262,
                    MemoryUtilization = 70.27986756
                },
                new Benchmark()
                {
                    Id = 3,
                    CpuUtilization = 39,
                    NetworkIn = 196705693,
                    NetworkOut = 177780732,
                    MemoryUtilization = 71.57827558
                }
            };
        }

        public void CreateBenchmark(Benchmark benchmark) => benchmarks.Add(benchmark);

        public void DeleteBenchmark(Benchmark benchmark) => benchmarks.Remove(benchmark);

        public Benchmark GetBenchmarkById(int id) => benchmarks.Find(x => x.Id == id);

        public IEnumerable<Benchmark> GetBenchmarks() => benchmarks;

        public bool Save() => throw new System.NotImplementedException();

        public void UpdateBenchmark(Benchmark benchmark) => throw new System.NotImplementedException();
    }
}