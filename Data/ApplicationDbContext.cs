using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RabotaTukRabotaTam.Data.Models;

namespace RabotaTukRabotaTam.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ListingUser>()
                .HasKey(x => new { x.UserId, x.ListingId });

            builder.Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(20)
                .IsRequired();

            builder
            .Entity<Category>()
                .HasData(new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Trade and sales",
                    ImgURL= "https://gikn.eu/wp-content/uploads/2020/02/Shopping-Cart-money.png"

                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bars and restaurants",
                    ImgURL = "https://st3.depositphotos.com/3272603/14306/v/450/depositphotos_143068019-stock-illustration-restaurant-cafe-cartoons-vector.jpg"
                },
                 new Category()
                 {
                     Id = Guid.NewGuid(),
                     Name = "Hotels",
                     ImgURL = "https://static.vecteezy.com/system/resources/previews/015/694/764/original/skyscraper-hotel-building-flat-cartoon-hand-drawn-illustration-template-with-view-on-city-space-of-street-panorama-design-vector.jpg"
                 },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Production",
                    ImgURL = "https://authorservices.taylorandfrancis.com/wp-content/uploads/2022/10/Icon_production-1170x1170.png"
                },
                 new Category()
                 {
                     Id = Guid.NewGuid(),
                     Name = "Office and business activities",
                     ImgURL = "https://static.vecteezy.com/system/resources/previews/003/623/370/original/planning-schedule-or-time-management-with-calendar-business-meeting-activities-and-events-organizing-process-office-working-background-illustration-vector.jpg"
                 },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Couriers and drivers",
                    ImgURL = "https://t3.ftcdn.net/jpg/02/62/29/32/360_F_262293274_BgGtnhf3gAZJkEt5vMj88oUK5Pwjguji.jpg"
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Architecture and construction",
                    ImgURL= "https://freedesignfile.com/upload/2017/03/City-building-construction-template-vectors-19.jpg"

                });

            base.OnModelCreating(builder);
        }
    }
}
