using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{

    public class Restaurant
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; } = null!;

        public string Name { get; set; }

        public string UserName { get; set; }

        public string? Phone { get; set; }

        public string? AddressText { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Meal> Meals { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<DoctorRestaurantDiscount> DoctorRestaurantDiscounts { get; set; }
    }
}
