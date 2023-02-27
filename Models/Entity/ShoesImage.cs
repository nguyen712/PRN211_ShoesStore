using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("ShoesImage")]
    public class ShoesImage
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("ImageId")]
        public Image image { get; set; }

        [ForeignKey("ShoesId")]
        public Shoes shoes { get; set; }
    }
}
