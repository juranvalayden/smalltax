using Microsoft.AspNetCore.Mvc;
using SmallTax.Data;
using SmallTax.Data.Factories;
using SmallTax.Data.Interfaces;
using SmallTax.ViewModels;

namespace SmallTax.Controllers
{
    public class AppController : Controller
    {
        private readonly ITaxRepository _repository;
        private readonly IPersonFactory _factory;

        public AppController(ITaxRepository repository, IPersonFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonalTax()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonalTax(PersonViewModel model)
        {
            if (!ModelState.IsValid) return View();

            var person = SimpleFactory.CreatePerson(model.PostalCode.ToString());
            ModelState.Clear();

            return View();
        }
    }
}
