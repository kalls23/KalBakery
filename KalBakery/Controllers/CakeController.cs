using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalBakery.Model;
using KalBakery.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KalBakery.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public CakeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public ViewResult List()
        {
            CakeListViewModel cakeListViewModel = new CakeListViewModel();
            cakeListViewModel.Cakes = _cakeRepository.AllCakes;

            ViewBag.Title = "SPECIALITY CAKES";
            return View(cakeListViewModel);
        }

        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);

            if(cake == null)
            {
                return NotFound();
            }
            return View(cake);
        }
    }
}
