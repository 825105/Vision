using Microsoft.EntityFrameworkCore;
using Storm.Data.interfaces;
using Storm.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storm.Data.Repository
{
    public class ProductRepository : IAllProduct
    {
        private readonly AppDBContent appDBContent;
        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Product> Product => appDBContent.Product.Include(c => c.Category);

        public IEnumerable<Product> getFavProduct => appDBContent.Product.Where(p => p.isFavourite).Include(c => c.Category);

        public Product GetObjectProduct(int productid) => appDBContent.Product.FirstOrDefault(p => p.id == productid);
    }
}
