using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    public interface IMotorcycleRepository
    {
        IQueryable<Motorcycle> GetMotorcycles();
        IQueryable<Motorcycle> GetMotorcyclesIncludeBrandsCategories();
        Task<Motorcycle> GetMotorcycleById(int? id);

        void AddMotorcycle(Motorcycle motorcycle);
        void SaveChanges();
        Motorcycle GetMotorcycleIncludeItsDealers(int? id);
    }
}