using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("SpecificallyShoesSize")]
    public class SpecificallyShoesSize
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("specificallyShoesId")]
        public SpecificallyShoesSize shoes { get; set; }

        [ForeignKey("sizeId")]
        public Size size { get; set; }
    }
}
