using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Simrelease.Models.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(25)]

        public string Menu_ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        public int GroupID { get; set; }
        [MaxLength(256)]
        public string MenuGroup { get; set; }
        [MaxLength(10)]
        public string Target { get; set; }
        public bool Status { get; set; }
    }
}


