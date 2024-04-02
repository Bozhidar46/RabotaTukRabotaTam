using System;
using Microsoft.AspNetCore.Identity;

namespace Rabota_tuk__rabota_tam.Data.Models
{
	public class User:IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public ICollection<ListingUser> ListingUsers { get; set; } = new List<ListingUser>();
	}
}

