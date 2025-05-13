using Microsoft.AspNetCore.Mvc;

namespace Pronia.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }
}
