using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Simrelease.Models.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(25)]

        public string Order_ID { get; set; }
        [Key]
        //[Column(Order =2)]
        [Column(TypeName = "varchar", Order = 2)]
        public string Product_ID { get; set; }
        public int Quantity { get; set; }
        public string Order { get; set; }
        public string Product { get; set; }
    }
}
