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
    public class PostCategory:AudiTable
    {
        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]

        public string PostCategory_ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        //public virtual IEnumerable<Post> Posts { set; get; }
        [MaxLength(256)]
        public string Post_ID { set; get; }
    }
}
