using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RabotaTukRabotaTam.Data.Models
{
	public class ListingUser
	{
		
		
		[ForeignKey(nameof(User))]
        public string? UserId { get; set; }
		[Required]
        public User? User { get; set; }

		[ForeignKey(nameof(Listing))]
        public Guid ListingId { get; set; }
		[Required]
        public Listing? Listing { get; set; }
		
	}
}

