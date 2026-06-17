using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    public class Nutritionist
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; } = null!;

        
        public string UserName { get; set; }

        
        public string FirstName { get; set; }

        public string? MidName { get; set; }

        
        public string LastName { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public decimal? Rating { get; set; }

        public DateTime CreateAt { get; set; }

        public ICollection<PatientNutritionist> PatientNutritionists { get; set; }
        public ICollection<DietPlan> DietPlans { get; set; }
        public ICollection<DoctorRestaurantDiscount> DoctorRestaurantDiscounts { get; set; }
    }
}
