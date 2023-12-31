﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simrelease.Models.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(25)]
        public string Orders_Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomeName { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerAdress { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerEmail { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerMobile { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { get; set; }
        [MaxLength(256)]
        public string PaymentMethod { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }
        public string OrderDetails { set; get; }


    }
}
