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
    [Table("Products")]
    public class Product : AudiTable
    {
        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(25)]

        public string Product_ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [MaxLength(256)]
        public string Image { set; get; }
        [Column(TypeName = "xml")]
        public string MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        //[ForeignKey("CategoryID")]
        public string ProductCategory { set; get; }
    }
}
