using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simrelease.Models.Models
{
    [Table("Dmkh")]
    public class Dmkh
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(25)]
        public string Ma_kh { get; set; }
        public string Ten_kh { get; set; }
        public string Ten_kh2 { get; set; }
        public string Addres { get; set; }
        public string Addres2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string nh_kh1 { get; set; }
        public string nh_kh2 { get; set; }
        public string nh_kh3 { get; set; }

    }
}
