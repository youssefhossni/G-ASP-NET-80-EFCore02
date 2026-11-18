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
    public class OrganizerProfileConfigration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.Property(p => p.Biography).HasMaxLength(500);
            builder.Property(p => p.WebsiteUrl).HasMaxLength(300);
            builder.Property(p => p.LogoUrl).HasMaxLength(300);
        }
    }
}
