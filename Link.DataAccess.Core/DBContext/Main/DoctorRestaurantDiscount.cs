using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class DoctorRestaurantDiscount
    {
        public int Id { get; set; }

        public int NutritionistId { get; set; }
        public Nutritionist Nutritionist { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public string? DiscountType { get; set; }

        public decimal? Value { get; set; }

        public bool IsActive { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public decimal? DiscountPercentage { get; set; }
    }
}
