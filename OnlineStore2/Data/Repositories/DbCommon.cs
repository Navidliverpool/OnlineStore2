using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    //This interface was suppose to be used for refactoring the project in order to implement DI. But I undo it and it's dependencies for now.
    public class DbCommon<MotorcycleVM> : IDbCommon<MotorcycleVM>
    {
        private readonly ApplicationDbContext _db;
        public DbCommon(ApplicationDbContext db)
        {
            _db = db;
        }

        public void EntryState(MotorcycleVM motorcycleVM)
        {
            _db.Entry(motorcycleVM).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}