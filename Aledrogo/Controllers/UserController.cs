﻿using Aledrogo.DTO;
using Aledrogo.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Aledrogo.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repo;
        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }
        [HttpPost("login")]
        public async Task<IActionResult> LogIn([FromBody] LogInDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            try
            {
                bool result = await _repo.LogIn(dto);
                return new ObjectResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Set([FromBody] RegistrationDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            try
            {
                var result = await _repo.Register(dto, "user");
                return new ObjectResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAll();
                return new ObjectResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpGet("{name}", Name = "GetUsersByName")]
        public async Task<IActionResult> Get(string name)
        {
            try
            {
                var result = await _repo.GetAllByName(name);
                return new ObjectResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpPut]
        public async Task<IActionResult> ChangePassword([FromBody]PasswordDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            try
            {
                var result = await _repo.ChangePassword(dto);
                return new ObjectResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpPut(Name = "ChangeRole")]
        public async Task<IActionResult> ChangeRole([FromBody]RoleDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            try
            {
                await _repo.ChangeRole(dto);
                return new EmptyResult();
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpGet("LogOut")]
        public async Task<IActionResult> LogOut()
        {
            await _repo.LogOut();
            return new NoContentResult();
        }
        [HttpDelete("{name}")]
        public async Task<IActionResult> Delete(string name)
        {
            bool result = await _repo.RemoveUser(name);

            return Json(result);
        }
    }
}
