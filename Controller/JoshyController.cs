using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joshy_api.Data;
using Joshy_api.Models;
using Microsoft.AspNetCore.Mvc;
using Joshy_api.Repository;

namespace Joshy_api.Controller;

    [Route("[controller]")]
    [ApiController]
    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 120)]
    public class JoshyController : ControllerBase
    {
        private readonly OnXRepository _repo;
        public JoshyController(OnXRepository repo)
        {
            _repo = repo;
        }

        [HttpGet(Name = "/OnX")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        {
            var users = _repo.GetUsers();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(users);
        }

        [HttpGet("/OnXId")]
        public IActionResult GetUserById(Guid Id)
        {
            var user = _repo.GetUser(Id);
            if(!_repo.UserExists(Id))
            {
                return NotFound();
            }
            if(!ModelState.IsValid)
            {
                return  BadRequest(ModelState);
            }
            return Ok(user);
        }

        // [HttpGet(Name = "Id")]
        // [ProducesResponseType(200, Type = typeof(User))]
        // [ProducesResponseType(400)]
        // public IActionResult GetUserId(Guid Id)
        // {
        //     var user = _repo.GetUser(Id);

        //     if(!_repo.UserExists(Id))
        //        return NotFound();

        //     if(!ModelState.IsValid)
        //         return BadRequest(ModelState);
        //     return Ok(user);
        // }

        
        // [HttpGet(Name = "Id")]
        // [ProducesResponseType(200, Type = typeof(decimal))]
        // public IActionResult GetPrice(Guid Id)
        // {
        //     if(!_repo.UserExists(Id))
        //        return NotFound();
        //     var price = _repo.Price(Id);
        //     if(!ModelState.IsValid)
        //         return BadRequest(ModelState);

        //     return Ok(price);
        // }
    }
