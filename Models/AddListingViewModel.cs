using System;
using RabotaTukRabotaTam.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace RabotaTukRabotaTam.Models
{
    public class AddListingViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(300)]
        [Required]
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string FirmName { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}

