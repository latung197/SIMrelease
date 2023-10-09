using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simrelease.Models.Model.Model
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisitedDate { set; get; }
        [MaxLength(256)]
        public string IPAddress { set; get; }
    }
}