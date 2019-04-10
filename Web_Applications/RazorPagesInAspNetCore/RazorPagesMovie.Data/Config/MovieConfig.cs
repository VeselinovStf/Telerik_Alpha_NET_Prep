using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorPagesMovie.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesMovie.Data.Config
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.ReleaseDate)
                .HasColumnType("Datetime2")
                .HasColumnName("Release Date");

            builder.Property(m => m.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(m => m.Title)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(m => m.Genre)
                .HasMaxLength(50)

                .IsRequired();
        }
    }
}
