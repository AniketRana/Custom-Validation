using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation.Models
{
    public class Emp
    {
        [Required]
        public string Name { get; set; }
        [aniketValidation]
        public string Message { get; set; }
    }
}