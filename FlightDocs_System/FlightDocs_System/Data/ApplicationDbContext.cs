using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FlightDocs_System.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Pilot>? Pilots { get; set; }
        public DbSet<Aircraft>? Aircraft { get; set; }
        public DbSet<Flight>? Flights { get; set; }
        public DbSet<FlightDocument>? FlightDocuments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            // Your code for configuring the database model
        }

        // Cấu hình database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
                .HasOne(s => s.Pilot)
                .WithMany()
               .HasForeignKey(s => s.ID_Pilot)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Flight>()
                .HasOne(s => s.Aircraft)
                .WithMany()
               .HasForeignKey(s => s.ID_Aircraft)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FlightDocument>()
               .HasOne(s => s.Flight)
               .WithMany()
              .HasForeignKey(s => s.ID_Flight)
              .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
