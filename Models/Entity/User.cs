using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System;

namespace PRN211_ShoesStore.Models.Entity
{
    [Table("User")]
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? updateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        [Required]
        public string email { get; set; }

        [ForeignKey("RoleId")]
        public Role role { get; set; }
    }
}
