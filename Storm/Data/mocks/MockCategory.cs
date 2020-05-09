using Storm.Data.interfaces;
using Storm.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storm.Data.mocks
{
    public class MockCategory : IProductCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        categoryName = "Услуги",
                        desc = "Предлагаемые виды услуг"

                    },
                    new Category
                    {
                        categoryName = "Товары",
                        desc = "Ассортимент продукции"

                    },
                };
            }
        }
    }
}
