using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using Link.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Core.Repository.Interface.Meals
{
    public class MealRepository : BaseRepository<Meal>, IMealRepository
    {
        internal HealthDbContext _context;
        public MealRepository(HealthDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
