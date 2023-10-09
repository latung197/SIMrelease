using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simrelease.Models.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(25)]
        public string Error_Id { get; set; }
        public string NameError { get; set; }
    }
}
