using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("Image")]
    public class Image
    {
        [Key]
        public int id { get; set; }

        public byte[] image { get; set; }

        public string createBy { get; set; }

        public DateTime? createDate { get; set; }

        public string updateBy { get; set; }

        public DateTime? lastModifiedDate { get; set; }
    }
}
