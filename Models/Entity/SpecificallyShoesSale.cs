using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("SpecificallyShoesSale   ")]
    public class SpecificallyShoesSale
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("specificallyShoes")]
        public SpecificallyShoes shoes { get; set; }

        [ForeignKey("saleId")]
        public Sale sale { get; set; }
    }
}
