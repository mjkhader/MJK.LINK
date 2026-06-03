using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Repository
{
    public class DoctorRestaurantDiscountRepository : BaseRepository<DoctorRestaurantDiscount>, IDoctorRestaurantDiscountRepository
    {
        internal HealthDbContext _context;
        public DoctorRestaurantDiscountRepository(HealthDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
