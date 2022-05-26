using BackComDOTNET.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace BackComDOTNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }
    }
}