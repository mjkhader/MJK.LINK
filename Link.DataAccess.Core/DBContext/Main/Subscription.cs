using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{

    public class Subscription
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public string? PlanType { get; set; }

        public int? MealsPerDay { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Status { get; set; }

        public ICollection<SubscriptionDay> SubscriptionDays { get; set; }
    }
}
