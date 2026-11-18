using ConsoleApp27.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Configration
{
    public class BadgeConfigration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> B)
        {
            B.HasIndex(b => b.BadgeNumber).IsUnique();
            B.Property(b=>b.IssuedDate).IsRequired();

            B.Property(b => b.Tier)
                   .HasConversion<string>()
                   .HasMaxLength(20);
        }
    }
}
