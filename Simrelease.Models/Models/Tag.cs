using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simrelease.Models.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]

        public string Tag_ID { set; get; }

        [MaxLength(256)]
        [Required]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Type { set; get; }
    }
}