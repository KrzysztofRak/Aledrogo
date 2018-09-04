using Aledrogo.DTO;
using Aledrogo.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace Aledrogo.Controllers
{
    [Route("api/[Controller]")]
    public class AddressController : Controller
    {
        private readonly IAddressRespository _repo;

        public AddressController(IAddressRespository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromHeader]string name)
        {
            try
            {
                var result = await _repo.GetAllUserAddresses(name);

                return new ObjectResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpGet("{id}", Name = "GetAddressById")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await _repo.GetAddressById(id);

                return new ObjectResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Set([FromBody]AddressDTO dto)
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
                bool result = await _repo.AddAddress(dto);

                return new JsonResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool result = await _repo.DeleteAddressById(id);

                return new JsonResult(result);
            }
            catch (Exception exc)
            {
                return BadRequest(exc);
            }
        }
    }
}
