using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.Repository
{
    public class PatientNutritionistRepository : BaseRepository<PatientNutritionist>, IPatientNutritionistRepository
    {
        internal HealthDbContext _context;

        public PatientNutritionistRepository(HealthDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
