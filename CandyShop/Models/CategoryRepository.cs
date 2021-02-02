using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbcontext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _appDbcontext.Categires;
    }
}
