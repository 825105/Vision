using Storm.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storm.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> getAllProduct { get; set; }
        public string CurrCategory { get; set; }
    }
}
