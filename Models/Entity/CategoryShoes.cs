using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("CategoryShoes")]
    public class CategoryShoes
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("categoryId")]
        public Category category { get; set; }

        [ForeignKey("shoesId")]
        public Shoes shoes { get; set; }
    }
}
