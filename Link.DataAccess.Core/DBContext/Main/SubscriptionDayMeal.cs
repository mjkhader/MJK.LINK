using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class SubscriptionDayMeal
    {
        public int Id { get; set; }

        public int SubDayId { get; set; }
        public SubscriptionDay SubscriptionDay { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public string? MealSlot { get; set; }
    }
}
