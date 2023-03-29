using Microsoft.AspNetCore.Mvc;
using SistemaConta.Presentation.Models.Account;

namespace SistemaConta.Presentation.Controllers
{
    public class AccountController : Controller
    {       

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }



        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(LoginViewModel model)
        {
            return View();
        }



        public IActionResult PasswordRecover()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordRecover(LoginViewModel model)
        {
            return View();
        }
    }
}
