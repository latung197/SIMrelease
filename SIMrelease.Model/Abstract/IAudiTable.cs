﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMrelease.Model.Abstract
{
    public interface IAudiTable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}
