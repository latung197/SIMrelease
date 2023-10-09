using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Simrelease.Models.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]

        public string Product_ID { set; get; }

        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        [MaxLength(25)]

        public string Tag_ID { set; get; }
        //[ForeignKey("ProductID")]
        [MaxLength(256)]
        public string Product { set; get; }
        //[ForeignKey("TagID")]
        [MaxLength(256)]
        public string Tag { set; get; }
    }
}