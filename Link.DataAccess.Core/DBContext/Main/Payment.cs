using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    public class Payment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order OrderTable { get; set; }

        public string? Method { get; set; }

        public decimal? Amount { get; set; }

        public string? Status { get; set; }

        public string? TransactionRef { get; set; }

        public DateTime? PaidAt { get; set; }


    }
}
