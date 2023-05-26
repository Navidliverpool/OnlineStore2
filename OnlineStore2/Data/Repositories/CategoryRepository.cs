using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        NavEcommerceDBfirstEntities_Model2OnlineStore2 _storeDB;
        public CategoryRepository(NavEcommerceDBfirstEntities_Model2OnlineStore2 storeDB)
        {
            _storeDB = storeDB;
        }
        public IQueryable<Category> GetCategories()
        {
            return _storeDB.Categories;
        }

        public Category GetCategoryById(int id)
        {
            return _storeDB.Categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}