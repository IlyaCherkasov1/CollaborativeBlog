using HelloApp.Data.Interfaces;
using HelloApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Controllers
{
    public class CarsController : Controller 
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory allCategory;

        public CarsController(IAllCars allCars, ICarsCategory allCategory)
        {
            this.allCars = allCars;
            this.allCategory = allCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Старница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = allCars.cars; 
            obj.currCategory = "автомобили";
            return View(obj);
        }
    }
}
