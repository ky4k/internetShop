using internetShop.Interfaces;
using internetShop.Models;

namespace internetShop.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{
                        categoryName = "Sports Car",
                        desc = "sports cars are two-seater convertibles that allow for open-air driving and have a sporty appearance"
                    },
                    new Category
                    {
                        categoryName = "Sedan",
                        desc = "A sedan is a conventional example of a four-door passenger car"
                    }
                };
            }
        }
    }
}
