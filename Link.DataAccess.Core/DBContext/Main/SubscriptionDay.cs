using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    public class SubscriptionDay
    {
        public int Id { get; set; }

        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }

        public DateTime Date { get; set; }

        public string? Status { get; set; }

        public ICollection<SubscriptionDayMeal> SubscriptionDayMeals { get; set; }
    }
}
