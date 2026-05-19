using DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBContext
{
    public class OrderTable
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public string? OrderType { get; set; }

        public string? Status { get; set; }

        public decimal? TotalPrice { get; set; }

        public decimal? DeliveryFee { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public Payment Payment { get; set; }
        public Delivery Delivery { get; set; }
    }
}
