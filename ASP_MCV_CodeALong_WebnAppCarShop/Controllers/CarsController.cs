using ASP_MCV_CodeALong_WebnAppCarShop.Controllers.Data;
using ASP_MCV_CodeALong_WebnAppCarShop.Models;
using ASP_MCV_CodeALong_WebnAppCarShop.Models.Repo;
using ASP_MCV_CodeALong_WebnAppCarShop.Models.Service;
using ASP_MCV_CodeALong_WebnAppCarShop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Controllers
{
    public class CarsController : Controller
    {
        ICarService _carService;
        ICarRepo _carRepo;
        ICarBrandRepo _carBrandRepo;
        CarShopDbContext _context;

        public CarsController(ICarService carService, ICarRepo carRepo, ICarBrandRepo carBrandRepo, CarShopDbContext context)
        {
            _carService = carService;
            _carRepo = carRepo;
            _carBrandRepo = carBrandRepo;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CarIndexViewModel vm = new CarIndexViewModel();
            vm.CarList = _context.Cars.ToList();

            if (CarRepo._carList.Count == 0)
            {
                CarRepo.CreateDefaultCars();
            }
            //return View(_carService.All()); //TODO add service for all cars
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(CarIndexViewModel indexViewModel)
        {
            indexViewModel.CarList = _carService.FindByBrand(indexViewModel.FilterText);
            return View(indexViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateCar(_carBrandRepo));
        }

        [HttpPost]
        public IActionResult Create(CreateCar createCar)
        {
            //If it works, we go back to main page
            if(ModelState.IsValid)
            {
                _carService.Add(createCar);

                return RedirectToAction(nameof(Index));
            }

            //If it doesn't work, we go back to create view.
            //Returnning createCar makes it so the all the values typed in by the user are still there.
            return View(createCar);
        }
    }
}
