using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joshy_api.Data;
using Joshy_api.Models

namespace Joshy_api.Controller
{
    [ApiController]
    [Route("api/[Joshies]")]
    public class JoshyController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
             var products = new List<>()
             new {

             }
        }
    }
}