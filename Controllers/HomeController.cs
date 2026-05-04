using Microsoft.AspNetCore.Mvc;

namespace LeveInvestimentos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
