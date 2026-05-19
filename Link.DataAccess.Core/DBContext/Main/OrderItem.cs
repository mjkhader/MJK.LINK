using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public OrderTable OrderTable { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public int Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? CaloriesSnapshot { get; set; }
    }
}
