using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simrelease.Models.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]
        public string SystemConfig_ID { set; get; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Code { set; get; }

        [MaxLength(50)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}