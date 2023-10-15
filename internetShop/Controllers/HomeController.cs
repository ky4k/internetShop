using internetShop.Interfaces;
using internetShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace internetShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;        

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };

            return View(homeCars);
        }
    }
}
