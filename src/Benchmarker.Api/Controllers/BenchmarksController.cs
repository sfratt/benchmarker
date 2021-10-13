using System.Collections.Generic;
using System.Linq;
using Benchmarker.Api.Data;
using Benchmarker.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Benchmarker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BenchmarksController : ControllerBase
    {
        private readonly IBenchmarkRepository _repository;

        public BenchmarksController(IBenchmarkRepository repository) => _repository = repository;

        [HttpGet]
        public ActionResult<IEnumerable<Benchmark>> Get()
        {
            var benchmarks = _repository.GetBenchmarks();
            if (!benchmarks.Any()) return NotFound();
            return Ok(benchmarks);
        }

        [HttpGet("{id}")]
        public ActionResult<Benchmark> Get(int id)
        {
            var benchmark = _repository.GetBenchmarkById(id);
            if (benchmark is null) return NotFound();
            return Ok(benchmark);
        }
    }
}