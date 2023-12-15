using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simrelease.Models.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public string Version { get; private set; }
    }
}
