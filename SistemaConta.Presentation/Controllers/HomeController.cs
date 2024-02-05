using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SistemaConta.Presentation.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {   //home/index    
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
