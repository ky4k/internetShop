using internetShop.Mocks;
using internetShop.Interfaces;
using internetShop.Models;

namespace internetShop.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                //    new Car
                //    {
                //        name = "Porsche 911",
                //        shortDesc = "Comfortable and Fashion car",
                //        longDesc = "The 2023 Porsche 911 blends world-class performance," +
                //        "iconic styling and daily driver versatility into an elegant and refined package.",
                //        img = "/img/porche911.jpg",
                //        price = 6660,
                //        isFavourite = false,
                //        available = true,
                //        Category = _categoryCars.AllCategories.First()
                //    },

                //    new Car
                //    {
                //        name = "Mercedes-AMG",
                //        shortDesc = "Strong car",
                //        longDesc = " it’s the performance versions of the E-Class family",
                //        img = "/img/m-amg.jpg",
                //        price = 9990,
                //        isFavourite = true,
                //        available = true,
                //        Category = _categoryCars.AllCategories.Last()
                //    },

                //    new Car
                //    {
                //        name = "BMW M4",
                //        shortDesc = "Powerfull and sexy car",
                //        longDesc = "Car 4 guys with big balls and pocket",
                //        img = "/img/bmw-m4.jpg",
                //        price = 1300,
                //        isFavourite = true,
                //        available = false,
                //        Category = _categoryCars.AllCategories.First()
                //    },

                //    new Car
                //    {
                //        name = "Tesla Roadster",
                //        shortDesc = "The first supercar to set every performance record and still fit seating for four.",
                //        longDesc = "The Roadster will be a new addition to the Tesla lineup when it eventually enters production," +
                //        " resurrecting the nameplate worn by the company's first model back in 2008. ",
                //        img = "/img/tesla.webp",
                //        price = 35000,
                //        isFavourite = true,
                //        available = true,
                //        Category = _categoryCars.AllCategories.First()
                //    }
                };

            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
