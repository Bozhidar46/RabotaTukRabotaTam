using System;
using RabotaTukRabotaTam.Data.Models;
using System.ComponentModel.DataAnnotations;
using RabotaTukRabotaTam.Data.Models;

namespace RabotaTukRabotaTam.Models
{
    public class UpdateListingViewModel
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
        public Category Category { get; set; }
        public List<User> Applicants { get; set; }
    }
}

