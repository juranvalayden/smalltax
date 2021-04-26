using Microsoft.AspNetCore.Mvc;
using SmallTax.ViewModels;

namespace SmallTax.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonalTax()
        {
            return View();
        }
    }
}
