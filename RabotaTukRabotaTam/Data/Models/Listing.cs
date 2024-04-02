using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Rabota_tuk__rabota_tam.Data.Models
{
	public class Listing
	{
        public Listing()
        {
			Id= Guid.NewGuid();
        }
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

		[ForeignKey(nameof(Category))]

		public Guid? CategoryId { get; set; }

		public Category Category { get; set; }

		public ICollection<ListingUser> ListingUsers { get; set; } = new List<ListingUser>();
	}
}

