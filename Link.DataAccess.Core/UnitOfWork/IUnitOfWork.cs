using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<User> Users{ get; }
        IBaseRepository<Restaurant> Restaurants { get; }


        int Complete();
        void Dispose();
    }
}
