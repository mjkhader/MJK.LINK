using DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string? Phone { get; set; }

        public string? AddressText { get; set; }

        public decimal? Lat { get; set; }

        public decimal? Lng { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Meal> Meals { get; set; }
        public ICollection<OrderTable> Orders { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<DoctorRestaurantDiscount> DoctorRestaurantDiscounts { get; set; }
    }
}
