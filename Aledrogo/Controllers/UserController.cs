using Aledrogo.DTO;
using Aledrogo.Repositories;
using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]
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

            bool result = await _repo.LogIn(dto);

            return new ObjectResult(result);
        }
        [HttpPost]
        public async Task<IActionResult> Registration([FromBody] RegistrationDTO dto)
        {
            if (dto == null)
            {
                return BadRequest("cos");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            var result = await _repo.Registration(dto, "user");

            return new ObjectResult(result);
        }
    }
}
