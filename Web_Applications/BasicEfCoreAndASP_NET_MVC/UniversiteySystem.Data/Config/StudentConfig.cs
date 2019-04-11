using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UniversitySystem.Models.Entities;

namespace UniversiteySystem.Data.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.FirstMidName)
                .HasMaxLength(100)
                .HasColumnName("First Middle Name")
                .IsRequired();

            builder.Property(s => s.LastName)
                .HasMaxLength(100)
                .HasColumnName("Last Name")
                .IsRequired();

            builder.Property(s => s.EnrollmentDate)
                .HasColumnType("datetime2")
                .HasColumnName("Entrollment Date");

            builder.HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.Student_Id);

        }
    }
}
