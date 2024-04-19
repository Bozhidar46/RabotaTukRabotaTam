using System;
using System.ComponentModel.DataAnnotations;

namespace RabotaTukRabotaTam.Data.Models
{
	public class Category
	{
		public Category()
		{
			Id = Guid.NewGuid();
		}

		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string ImgURL { get; set; }

		public List<Listing> Listings { get; set; } = new List<Listing>();
	}
}

