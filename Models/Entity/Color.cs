using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("Color")]
    public class Color
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string createBy { get; set; }

        public DateTime? createDate { get; set; }

        public string updateBy { get; set; }

        public DateTime? updateDate { get; set; }
    }
}
