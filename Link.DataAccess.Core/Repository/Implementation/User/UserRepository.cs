using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        internal HealthDbContext _context;
        public UserRepository(HealthDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
