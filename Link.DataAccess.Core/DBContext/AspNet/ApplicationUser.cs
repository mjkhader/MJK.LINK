using DataAccess.DBContext;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    public class ApplicationUser : IdentityUser
    {
        // Custom fields can be added here later

        public User? User { get; set; }
        public Nutritionist? Nutritionist { get; set; }
        public Restaurant? Restaurant { get; set; }
        public Driver? Driver { get; set; }
    }
}
