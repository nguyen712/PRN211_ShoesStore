using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
