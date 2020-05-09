using Storm.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Storm.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Category.Any())
                content.Category.AddRange(Сategories.Select(c => c.Value));

            if (!content.Product.Any())
                content.AddRange(
                    new Product
                    {
                        name = "Монтаж",
                        shortdesc = "Производится специалистами рукожо##ми",
                        longdesc = "Зато они относятся с уважением к заказчику и строительным материалам",
                        img = "/img/test_1.png",
                        price = 4000,
                        isFavourite = true,
                        available = true,
                        Category = Сategories["Товары"]
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
                        Category = Сategories["Товары"]
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
                        Category = Сategories["Услуги"]
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
                        Category = Сategories["Услуги"]
                    });
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Сategories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {

                        new Category{categoryName = "Услуги", desc = "Предлагаемые виды услуг"},
                        new Category{categoryName = "Товары", desc = "Ассортимент продукции"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}

