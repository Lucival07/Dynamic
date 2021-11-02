using Dynamic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dynamic.Configuration
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("test", "mechanics")
                .HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int(11)");

            builder.Property(x => x.Nome)
               .IsRequired()
               .HasColumnName("Nome")
               .HasColumnType("varchar(200)");

        }
    }
}
