using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simrelease.Models.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {

        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(25)]

        public string MenuGroup_ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Menus { get; set; }
    }
}
