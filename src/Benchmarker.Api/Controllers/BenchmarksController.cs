using System;
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
        public async Task<IActionResult> Get([FromBody] RequestForWorkload workload)
        {
            Console.WriteLine($"Metric: {workload.Metric}, Batch ID: {workload.BatchId}");
            var benchmarks = await _repository.GetBenchmarksAsync();
            if (!benchmarks.Any()) return NotFound();
            ResponseForData response = new()
            {
                Id = workload.Id,
                BatchId = workload.BatchId,
                Data = benchmarks
            };
            // return Ok(_mapper.Map<IEnumerable<ResponseForData>>(benchmarks));
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseForData))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] int id, [FromBody] RequestForWorkload workload)
        {
            var benchmark = await _repository.GetBenchmarkAsync(id);
            if (benchmark is null) return NotFound();
            ResponseForData response = new()
            {
                Id = workload.Id,
                BatchId = workload.BatchId,
                Data = new[] { benchmark }
            };
            // return Ok(_mapper.Map<BenchmarkReadDto>(benchmark));
            return Ok(response);
        }
    }
}