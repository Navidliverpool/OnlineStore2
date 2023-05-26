using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    public class DealerRepository : IDealerRepository
    {
        NavEcommerceDBfirstEntities_Model2OnlineStore2 _storeDB;
        public DealerRepository(NavEcommerceDBfirstEntities_Model2OnlineStore2 storeDB)
        {
            _storeDB = storeDB;
        }
        public IQueryable<Dealer> GetDealers()
        {
            return _storeDB.Dealers;
        }
        public Dealer GetDealerById(int id)
        {
            return _storeDB.Dealers.FirstOrDefault(d => d.DealerId == id);
        }
    }
}