using internetShop.Models;

namespace internetShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            //content == null
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(

                    new Car
                    {
                        name = "Porsche 911",
                        shortDesc = "Comfortable and Fashion car",
                        longDesc = "The 2023 Porsche 911 blends world-class performance," +
                        "iconic styling and daily driver versatility into an elegant and refined package.",
                        img = "/img/Xporche911.jpg",
                        price = 215000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Sports"]
                    },

                    new Car
                    {
                        name = "Mercedes-AMG",
                        shortDesc = "Strong car",
                        longDesc = " it’s the performance versions of the E-Class family",
                        img = "/img/XClaAmg.jpg",
                        price = 193000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Sedan"]
                    },

                    new Car
                    {
                        name = "BMW M4",
                        shortDesc = "Powerfull and sexy car",
                        longDesc = "Car 4 guys with big balls and pocket",
                        img = "/img/Xbmw-m4.jpg",
                        price = 87000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Sedan"]
                    },
                    
                    new Car
                    {
                        name = "Tesla Roadster",
                        shortDesc = "The first supercar to set every performance record and still fit seating for four.",
                        longDesc = "The Roadster will be a new addition to the Tesla lineup when it eventually enters production," +
                        " resurrecting the nameplate worn by the company's first model back in 2008. ",
                        img = "/img/XteslaRoadster.jpg",
                        price = 200000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Sports"]
                    },

                    new Car
                    {
                        name = "McLaren720",
                        shortDesc = "Supercar",
                        longDesc = "The 720S sits in McLaren's Super Series line-up alongside a convertible Spider version and the 765LT model",
                        img = "/img/XMcLaren720S.jpg",
                        price = 283000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Sports"]
                    },

                    new Car
                    {
                        name = "ToyotaGR Supra",
                        shortDesc = "Drift Supercar",
                        longDesc = "The driving experience was clearly prioritised in the Supra’s development, and for sheer driving thrills it’s a winner.",
                        img = "/img/XToytaGRSupra.jpg",
                        price = 44000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Sports"]
                    },

                    new Car
                    {
                        name = "Kia k5",
                        shortDesc = "Comfortable car",
                        longDesc = "180-hp, GT-specific 290hp",
                        img = "/img/XKiaK5.jpg",
                        price = 30000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Sedan"]
                    },

                    new Car
                    {
                        name = "Audi A7",
                        shortDesc = "nice Sedan ",
                        longDesc = "180hp",
                        img = "/img/XXAudiA7.jpg",
                        price = 80000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Sedan"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Sports", desc = "Sports cars are two-seater.."},
                        new Category{categoryName = "Sedan", desc = "Conventional example of a four-door passenger car"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                }
                return category;
            }
        }
    }
}
