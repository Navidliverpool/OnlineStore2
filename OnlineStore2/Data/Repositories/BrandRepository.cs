using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        ApplicationDbContext _storeDB;
        public BrandRepository(ApplicationDbContext storeDB)
        {
            _storeDB = storeDB;
        }
        public IQueryable<Brand> GetBrands()
        {
            return _storeDB.Brands;
        }
        public Brand GetBrandById(int id)
        {
            return _storeDB.Brands.FirstOrDefault(b => b.BrandId == id);
        }
    }
}