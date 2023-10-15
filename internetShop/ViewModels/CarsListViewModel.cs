using internetShop.Models;

namespace internetShop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car>? allCars { get; set; }

        public string? carCategory { get; set; }
    }
}
