using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace VuQuangHuy013.Models
{
    [Table("NTN0535s")]
    public class VQH1013
    {
        [Key]
        [StringLength(20)]
        public string VQHId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage="Yêu cầu nhập NTNName.")]
        [Display(Name = "Tên")]
        public string VQHName { get; set; }
        [Required(ErrorMessage="Yêu cầu nhập NTNGender.")]
        [Display(Name = "Giới Tính")]
        public string VQHGender { get; set; }
    }
    
}