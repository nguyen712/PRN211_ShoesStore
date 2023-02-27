using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("Sale")]
    public class Sale
    {
        [Key]
        public int id { get; set; }

        [Required]
        public double discount { get; set; }
    }
}
