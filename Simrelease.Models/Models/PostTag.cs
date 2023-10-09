using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simrelease.Models.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]

        public string Post_ID { set; get; }

        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        [MaxLength(25)]

        public string Tag_ID { set; get; }

        //[ForeignKey("PostID")]
        public string Post { set; get; }

        //[ForeignKey("TagID")]
        public string Tag { set; get; }
    }
}
