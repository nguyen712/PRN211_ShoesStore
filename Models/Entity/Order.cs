using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int orderId { get; set; }

        [ForeignKey("UserId")]
        public User user { get; set; }

        [Column(TypeName = "Money")]
        public decimal price { get; set; }

        public DateTime? createDate { get; set; }
    }
}
