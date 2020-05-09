using Microsoft.AspNetCore.Mvc;
using Storm.Data.interfaces;
using Storm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storm.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProduct _allproduct;
        private readonly IProductCategory _allcategories;

        public ProductController (IAllProduct iallProduct, IProductCategory iproductCategory)
        {
            _allproduct = iallProduct;
            _allcategories = iproductCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "TECHSTROISVYAZ";
            ProductListViewModel obj = new ProductListViewModel
            {
                getAllProduct = _allproduct.Product,
                CurrCategory = "Товары"
            };
            return View(obj);
            /*ViewBag.Category = "Some New";
            var product = _allproduct.Product;
            return View(product);*/

        }
    }
}
