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
    [Table("Posts")]
    public class Post:AudiTable
    {
        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]

        public string Post_ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }
        [Required]
        public int CategoryID { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        //[ForeignKey("CategoryID")]
        public string PostCategory_ID { set; get; }
        public string PostTag_ID { set; get; }
    }
}
