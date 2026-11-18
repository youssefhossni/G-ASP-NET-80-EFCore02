using ConsoleApp27.Configration;
using ConsoleApp27.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Context
{
    public class EventHubContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet <Attendee>Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(E =>
            {
                E.Property(x => x.Title).IsRequired(true).HasMaxLength(200);
                E.Property(x => x.Description).IsRequired(true);
                E.Property(x => x.StartDate).IsRequired(true);

            }
              




            );
            modelBuilder.ApplyConfiguration(new BadgeConfigration());
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfigration());

        }
    }

   
}
