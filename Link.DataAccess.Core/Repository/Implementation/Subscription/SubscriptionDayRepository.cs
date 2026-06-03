using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Repository
{
    public class SubscriptionDayRepository : BaseRepository<SubscriptionDay>, ISubscriptionDayRepository
    {
        internal HealthDbContext _context;

        public SubscriptionDayRepository(HealthDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
