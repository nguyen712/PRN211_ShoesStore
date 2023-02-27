using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("ShoesColor")]
    public class ShoesColor
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("ShoesId")]
        public Shoes shoes { get; set; }

        [ForeignKey("ShoesId")]
        public Color color { get; set; }
    }
}
