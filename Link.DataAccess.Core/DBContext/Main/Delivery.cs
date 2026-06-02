using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class Delivery
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public OrderTable OrderTable { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public DateTime? PickupTime { get; set; }
        public DateTime? DeliveredTime { get; set; }
        public string? Status { get; set; }

        public ICollection<DriverLocation> DriverLocations { get; set; }
    }
}
