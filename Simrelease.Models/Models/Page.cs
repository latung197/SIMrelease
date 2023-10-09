using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Simrelease.Models.Abstract;
namespace Simrelease.Models.Models
{
    [Table("pages")]
    public class Page : AudiTable
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]

        public string Page_ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { get; set; }
        public string Content { get; set; }
    }
}
