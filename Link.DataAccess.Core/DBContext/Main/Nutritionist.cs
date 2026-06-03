using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    [Table("Nutritionists")]
    public class Nutritionist
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string? MidName { get; set; }

        [Required]
        [MaxLength(50)]
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
