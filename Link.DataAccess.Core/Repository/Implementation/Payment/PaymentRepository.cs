using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Repository
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        internal HealthDbContext _context;

        public PaymentRepository(HealthDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
