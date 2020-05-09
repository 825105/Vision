using Storm.Data.interfaces;
using Storm.Data.Models;
using System.Collections.Generic;

namespace Storm.Data.Repository
{
    public class CategoryRepository : IProductCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
        
    }
}
