using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Models
{
    public class Converter
    {
        [Required]
        [Display(Name = "Value")]
        [Range(1, double.MaxValue, ErrorMessage = "Value must be a positive number")]
        public decimal amount { get; set; }

        [Required]
        [Display(Name = "From")]
        public string FromValue { get; set; }

        [Required]
        [Display(Name = "To")]
        public string ToValue { get; set; }
    }
}