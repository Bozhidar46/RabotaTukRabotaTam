using System;
using System.ComponentModel.DataAnnotations;

namespace RabotaTukRabotaTam.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(100, MinimumLength = 10)]
        public string EmailAddress { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

    }
}

