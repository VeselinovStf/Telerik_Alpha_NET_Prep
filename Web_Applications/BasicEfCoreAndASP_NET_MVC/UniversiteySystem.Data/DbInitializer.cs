using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models.Common;
using UniversitySystem.Models.Entities;

namespace UniversiteySystem.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(UniversitySystemDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (!context.Students.Any())
            {
                var students = new Student[]
                {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
                };

                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }

                await context.SaveChangesAsync();
            }

            if (!context.Courses.Any())
            {
                var courses = new Course[]
            {
              new Course{Title="Chemistry",Credits=3},
              new Course{Title="Microeconomics",Credits=3},
              new Course{Title="Macroeconomics",Credits=3},
              new Course{Title="Calculus",Credits=4},
              new Course{Title="Trigonometry",Credits=4},
              new Course{Title="Composition",Credits=3},
              new Course{Title="Literature",Credits=4}
            };

                foreach (Course c in courses)
                {
                    context.Courses.Add(c);
                }

                await context.SaveChangesAsync();
            }

            if (!context.Enrollments.Any())
            {
                var enrollments = new Enrollment[]
            {
                new Enrollment{Student_Id=1,Course_Id=1,Grade=Grade.A},
                new Enrollment{Student_Id=1,Course_Id=2,Grade=Grade.C},
                new Enrollment{Student_Id=1,Course_Id=3,Grade=Grade.B},
                new Enrollment{Student_Id=2,Course_Id=4,Grade=Grade.B},
                new Enrollment{Student_Id=2,Course_Id=5,Grade=Grade.F},
                new Enrollment{Student_Id=2,Course_Id=6,Grade=Grade.F},
                new Enrollment{Student_Id=3,Course_Id=1},
                new Enrollment{Student_Id=4,Course_Id=1},
                new Enrollment{Student_Id=4,Course_Id=2,Grade=Grade.F},
                new Enrollment{Student_Id=5,Course_Id=3,Grade=Grade.C},
                new Enrollment{Student_Id=6,Course_Id=4},
                new Enrollment{Student_Id=7,Course_Id=5,Grade=Grade.A},
            };

                foreach (Enrollment e in enrollments)
                {
                    context.Enrollments.Add(e);
                }

                await context.SaveChangesAsync();
            }
        }
    }
}
