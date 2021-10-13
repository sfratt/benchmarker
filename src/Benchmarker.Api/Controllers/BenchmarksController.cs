using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Benchmarker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BenchmarksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "This", "is", "hard", "coded" };
        }
    }
}