using System.Collections.Generic;
using Benchmarker.Api.Models;

namespace Benchmarker.Api.Data
{
    /// <summary>
    /// Interface <c>IBenchmarkRepository</c> defines the CRUD methods needed by the repository pattern.
    /// Referenced <see href="https://codewithshadman.com/repository-pattern-csharp/">here</see>.
    /// Additional reference <see href="https://stackoverflow.com/questions/49990365/entity-framework-core-2-0-how-to-configure-abstract-base-class-once">here</see>.
    /// </summary>
    /// <remarks>A generic interface for the different data models will most likely be required</remarks>
    public interface IBenchmarkRepository
    {
        IEnumerable<Benchmark> GetBenchmarks();
        Benchmark GetBenchmarkById(int id);
        void CreateBenchmark(Benchmark benchmark);
        void UpdateBenchmark(Benchmark benchmark);
        void DeleteBenchmark(Benchmark benchmark);
        bool Save(); // should this just return nothing (void)?
    }
}