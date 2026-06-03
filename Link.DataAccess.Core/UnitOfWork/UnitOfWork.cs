using DataAccess.DBContext;
using Link.DataAccess.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HealthDbContext _context;

        public UnitOfWork(HealthDbContext context)
        {
            _context = context;
            Users = new BaseRepository<User>(_context);
            Restaurants = new BaseRepository<Restaurant>(_context);
        }

        public IBaseRepository<User> Users { get; }
        public IBaseRepository<Restaurant> Restaurants { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
