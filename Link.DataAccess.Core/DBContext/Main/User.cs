using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    public class User
    {
        public int Id { get; set; }

        public string AspNetUserId { get; set; } = null!;
        public string FirstName { get; set; }
        public string? MidName { get; set; }
        public string LastName { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string? Goal { get; set; }
        public DateTime CreateAt { get; set; }
        public string UserName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }



        public ICollection<PatientNutritionist> PatientNutritionists { get; set; }
        public ICollection<DietPlan> DietPlans { get; set; }
        public ICollection<UserCondition> UserConditions { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}

