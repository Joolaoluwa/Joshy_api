using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joshy_api.Data;
using Joshy_api.Models;
using Microsoft.AspNetCore.Mvc;
using Joshy_api.Repository;

namespace Joshy_api.Controller;

    [Route("/OnX")]
    [ApiController]
    public class JoshyController : ControllerBase
    {
        private readonly OnXRepository _repo;
        public JoshyController(OnXRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetUser()
        {
            var users = _repo.GetUsers();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(users);
        }

    }
