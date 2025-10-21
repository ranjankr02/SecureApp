using Microsoft.AspNetCore.Mvc;

namespace SecureApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }
    }
}
