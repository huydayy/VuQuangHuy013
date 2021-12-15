using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace VuQuangHuy013.Models
{	
[Table("CompanyVQH013s")]

    public class CompanyVQH013
    {
        [Key]
        [StringLength(20)]
        public string CompanyId { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string CompanyName { get; set; }
    }
}