using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("ColorSpecificallyShoes")]
    public class ColorSpecificallyShoes
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("specificallyShoesId")]
        public SpecificallyShoes shoes { get; set; }

        [ForeignKey("colorId")]
        public Color color { get; set; }

    }
}
