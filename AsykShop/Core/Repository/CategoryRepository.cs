using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsykShop.Core.Repository
{
    public class CategoryRepository : IAsyktarCategory
    {
        private readonly AppDBContent _appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Category> GetAllCategories => _appDBContent.Category;
    }
}
