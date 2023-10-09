using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simrelease.Models.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(25)]

        public string Footer_Id { get; set; }
        [Required] // Không được để trống
        public string Content { get; set; }
    }
}
