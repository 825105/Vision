using Storm.Data.interfaces;
using Storm.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storm.Data.mocks
{
    public class MockProduct : IAllProduct
    {
        private readonly IProductCategory _categoryProduct = new MockCategory();

        public IEnumerable<Product> Product
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        name = "Монтаж",
                        shortdesc = "Производится специалистами рукожо##ми",
                        longdesc = "Зато они относятся с уважением к заказчику и строительным материалам",
                        img = "/img/test_1.png",
                        price = 4000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProduct.AllCategories.First()
                    },
                    new Product
                    {
                        name = "Установка",
                        shortdesc = "Производится специалистами рукожо##ми",
                        longdesc = "Зато они относятся с уважением к заказчику и строительным материалам",
                        img = "/img/test_2.png",
                        price = 1000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProduct.AllCategories.Last()
                    },
                    new Product
                    {
                        name = "Работы",
                        shortdesc = "Производится специалистами рукожо##ми",
                        longdesc = "Зато они относятся с уважением к заказчику и строительным материалам",
                        img = "/img/test_1.png",
                        price = 10000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProduct.AllCategories.Last()
                    },
                    new Product
                    {
                        name = "Слуги",
                        shortdesc = "Производится специалистами рукожо##ми",
                        longdesc = "Зато они относятся с уважением к заказчику и строительным материалам",
                        img = "/img/test_2.png",
                        price = 51000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryProduct.AllCategories.First()
                    }
                };
            }
        }
            /*set => throw new NotImplementedException(); }*/
        public IEnumerable<Product> getFavProduct { get; set; }

        public Product GetObjectProduct(int productid)
        {
            throw new NotImplementedException();
        }
    }
}
