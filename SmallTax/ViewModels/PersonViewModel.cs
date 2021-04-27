using System;
using System.ComponentModel.DataAnnotations;

namespace SmallTax.ViewModels
{
    public class PersonViewModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        
        [Required]
        [MinLength(4)]
        public string PostalCode { get; set; }

        [Required]
        public decimal AnnualSalary { get; set; }

        public DateTime CreatedDate => DateTime.Now;
    }
}