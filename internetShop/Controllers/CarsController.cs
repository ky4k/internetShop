using internetShop.Interfaces;
using internetShop.Models;
using internetShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace internetShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars IallCars, ICarsCategory IcarsCategories)
        {
            _allCars = IallCars;
            _allCategories = IcarsCategories;
        }

        [Route("Cars/List/")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars;
            string currCategory = "";

            if (string.IsNullOrEmpty(category)){
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Sedan", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars
                        .Where(i => i.categoryID == 2)
                        .OrderBy(i => i.id);
                }
                else
                {
                    cars = _allCars.Cars.Where(i => i.categoryID == 1)
                        .OrderBy(i => i.id);                    
                }
                currCategory= _category;
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                carCategory = currCategory,
            };

            ViewBag.Title = "Car's Page";

            return View(carObj);
        }
    }
}
