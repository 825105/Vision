using Storm.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storm.Data.interfaces
{
    public interface IAllProduct
    {
        IEnumerable<Product> Product { get; /*set;*/ }
        IEnumerable<Product> getFavProduct { get; /*set;*/ }
        Product GetObjectProduct(int productid);
    }
}
