using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class PatientNutritionist
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int NutritionistId { get; set; }
        public Nutritionist Nutritionist { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }
    }
}
