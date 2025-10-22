using Microsoft.AspNetCore.Mvc;
using SecureApp.SecureApp.BAL.Services;
using System.Security.Cryptography.X509Certificates;

namespace SecureApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }
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
