using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Survivor.Services;
using Survivor.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Survivor.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly SurvivorContext _db;

        public UsersController(IUserService userService, SurvivorContext db)
        {
            _userService = userService;
            _db = db;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User1 userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);
            
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            return Ok(users);
        }
        [AllowAnonymous]
        [HttpPost("create")]
        public IActionResult Create([FromBody]User1 newUser)
        {
            _userService.Create(newUser);
            return Ok(newUser);
        }
    }
}