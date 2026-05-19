using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class Driver
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string? MidName { get; set; }

        public string LastName { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? VehicleType { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Delivery> Deliveries { get; set; }
    }
}
