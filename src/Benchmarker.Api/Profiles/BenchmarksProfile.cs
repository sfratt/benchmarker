using AutoMapper;
using Benchmarker.Api.DataTransferObjects;
using Benchmarker.Api.Models;

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