using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class Meal
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? Calories { get; set; }

        public decimal? Protein { get; set; }

        public decimal? Carbs { get; set; }

        public decimal? Fat { get; set; }

        public bool IsAvailable { get; set; }

        public ICollection<MealTag> MealTags { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<SubscriptionDayMeal> SubscriptionDayMeals { get; set; }
    }
}
