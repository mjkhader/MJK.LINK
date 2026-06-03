using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.DataAccess.DBContext
{
    [Table("Orders")]

    public class Order
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
        public ICollection<Payment> Payments { get; set; }
        public Delivery? Delivery { get; set; }
    }
}
