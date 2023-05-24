using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private readonly NavEcommerceDBfirstEntities_Model2OnlineStore2 _storeDB;
        public MotorcycleRepository(NavEcommerceDBfirstEntities_Model2OnlineStore2 storeDB)
        {
            _storeDB = storeDB;
        }

        //public MotorcycleRepository()
        //{

        //}
        public IQueryable<Motorcycle> GetMotorcycles()
        {
            return _storeDB.Motorcycles;
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            _storeDB.Motorcycles.Add(motorcycle);
        }

        public IQueryable<Motorcycle> GetMotorcyclesIncludeBrandsCategories()
        {
            if (_storeDB == null)
            {
                throw new Exception("_storeDB is null");
            }

            return _storeDB.Motorcycles.Include(m => m.Brand).Include(m => m.Category);
        }

        public async Task<Motorcycle> GetMotorcycleById(int? id)
        {
            return await _storeDB.Motorcycles.FindAsync(id);
        }

        public Motorcycle GetMotorcycleIncludeItsDealers(int? id)
        {
            return _storeDB.Motorcycles.Include(i => i.Dealers).First(i => i.MotorcycleId == id);
        }

        public async void SaveChanges()
        {
            await _storeDB.SaveChangesAsync();
        }

        ////This method was suppose to be used for refactoring the project in order to implement DI. But I undo it for now.
        //void IDbCommon<MotorcycleVM>.EntryState(MotorcycleVM motorcycleVM)
        //{
        //    _storeDB.Entry(motorcycleVM).State = System.Data.Entity.EntityState.Modified;
        //    _storeDB.SaveChanges();
        //}
    }
}