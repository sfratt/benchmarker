using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Benchmarker.Api.Data;
using Benchmarker.Api.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Benchmarker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BenchmarksController : ControllerBase
    {
        private readonly IBenchmarkRepository _repository;
        private readonly IMapper _mapper;

        public BenchmarksController(IBenchmarkRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ResponseForData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get()
        {
            var benchmarks = await _repository.GetBenchmarksAsync();
            if (!benchmarks.Any()) return NotFound();
            return Ok(_mapper.Map<IEnumerable<ResponseForData>>(benchmarks));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseForData))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var benchmark = await _repository.GetBenchmarkAsync(id);
            if (benchmark is null) return NotFound();
            return Ok(_mapper.Map<ResponseForData>(benchmark));
        }
    }
}