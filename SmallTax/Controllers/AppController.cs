using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmallTax.Data;
using SmallTax.Data.Entities;
using SmallTax.Data.Factories;
using SmallTax.Data.Interfaces;
using SmallTax.ViewModels;

namespace SmallTax.Controllers
{
    public class AppController : Controller
    {
        private readonly ITaxRepository _repository;
        private readonly IPersonFactory _factory;
        private readonly IMapper _mapper;

        public AppController(ITaxRepository repository, IPersonFactory factory, IMapper mapper)
        {
            _repository = repository;
            _factory = factory;
            _mapper = mapper;
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
            
            var person = SimpleFactory.CreatePerson(_mapper.Map<PersonViewModel, Person>(model));

            var totalTax = person.TotalTax();

            ModelState.Clear();

            return View();
        }
    }
}
