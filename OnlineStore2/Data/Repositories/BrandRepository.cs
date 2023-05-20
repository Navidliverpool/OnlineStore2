using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        NavEcommerceDBfirstEntities_Model2OnlineStore2 _storeDB;
        public BrandRepository(NavEcommerceDBfirstEntities_Model2OnlineStore2 storeDB)
        {
            _storeDB = storeDB;
        }
        public IQueryable<Brand> GetBrands()
        {
            return _storeDB.Brands;
        }
    }
}