using AutoMapper;
using Benchmarker.Domain.DataTransferObjects;
using Benchmarker.Domain.Models;

namespace Benchmarker.Api.Profiles
{
    public class BenchmarksProfile : Profile
    {
        /// <summary>
        /// Class <c>BenchmarksProfile</c> configures the mapping between model and DTO.
        /// </summary>
        /// <remarks>Source -> Destination</remarks>
        public BenchmarksProfile()
        {
            CreateMap<Benchmark, ResponseForData>();
        }
    }
}