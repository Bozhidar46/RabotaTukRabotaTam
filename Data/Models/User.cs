using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RabotaTukRabotaTam.Data.Models
{
	public class User:IdentityUser
	{
        [StringLength(20)]
        public string? FirstName { get; set; }

        [StringLength(20)]
        public string? LastName { get; set; }

        [Required]
        public int Age { get; set; }
        public ICollection<ListingUser> ListingUsers { get; set; } = new List<ListingUser>();
	}
}

