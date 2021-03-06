using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Benchmarker.DataAccess.Repositories;
using Benchmarker.Domain.DataTransferObjects;
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
        public async Task<IActionResult> Get([FromBody] RequestForWorkload request)
        {
            var benchmarks = await _repository.GetBenchmarksAsync(request);
            if (!benchmarks.Any()) return NotFound();
            ResponseForData response = new()
            {
                Id = request.Id,
                BatchId = request.BatchId,
                Data = benchmarks
            };
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseForData))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] Guid id, [FromBody] RequestForWorkload request)
        {
            var benchmark = await _repository.GetBenchmarkAsync(id);
            if (benchmark is null) return NotFound();
            ResponseForData response = new()
            {
                Id = request.Id,
                BatchId = request.BatchId,
                // Data = new[] { benchmark }
            };
            // return Ok(_mapper.Map<BenchmarkReadDto>(benchmark));
            return Ok(response);
        }
    }
}