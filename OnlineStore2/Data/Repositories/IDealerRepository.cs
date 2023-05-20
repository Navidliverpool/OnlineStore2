using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore2.Models;

namespace OnlineStore2.Data.Repositories
{
    public interface IDealerRepository
    {
        IQueryable<Dealer> GetDealers();
    }
}
