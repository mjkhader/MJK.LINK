using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class DriverLocation
    {
        public int Id { get; set; }

        public int DeliveryId { get; set; }
        public Delivery Delivery { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public DateTime RecordedAt { get; set; }
    }
}
