using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Benchmarker.Domain.DataTransferObjects;
using Benchmarker.Domain.Models;

namespace Benchmarker.DataAccess.Repositories
{
    /// <summary>
    /// Interface <c>IBenchmarkRepository</c> defines the CRUD methods needed by the repository pattern.
    /// </summary>
    public interface IBenchmarkRepository
    {
        Task<IEnumerable<string>> GetBenchmarksAsync(RequestForWorkload request);
        Task<Benchmark> GetBenchmarkAsync(Guid id);
        Task CreateBenchmarkAsync(Benchmark benchmark);
        Task UpdateBenchmarkAsync(Benchmark benchmark);
        Task DeleteBenchmarkAsync(Guid id);
        bool Save(); // should this just return nothing (void)?
    }
}