using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContosoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            Student[] students = new Student[]
            {
                new Student{ FirstName = "Valer", LastName = "Gelbakhiani", EnrollmentDate = DateTime.Parse("2003-05-28") },
                new Student{ FirstName = "Gubaz", LastName = "Sanikidze", EnrollmentDate = DateTime.Parse("2003-07-03") },
                new Student{ FirstName = "Giorgi", LastName = "Jorjadze", EnrollmentDate = DateTime.Parse("2004-05-28") },
                new Student{ FirstName = "Rati", LastName = "Giorgadze", EnrollmentDate = DateTime.Parse("1994-05-24") },
                new Student{ FirstName = "Avto", LastName = "Kamikadze", EnrollmentDate = DateTime.Parse("2004-05-28") },
                new Student{ FirstName = "Davit", LastName = "Akhvlediani", EnrollmentDate = DateTime.Parse("2004-05-28") },
                new Student{ FirstName = "Giorgi", LastName = "Akhvlediani", EnrollmentDate = DateTime.Parse("1994-05-03") },
                new Student{ FirstName = "Davit", LastName = "Gogolidze", EnrollmentDate = DateTime.Parse("2001-02-07") },
                new Student{ FirstName = "Giorgi", LastName = "Gogua", EnrollmentDate = DateTime.Parse("2004-02-07") },
            };

            foreach (Student s in students)
            {
                context.Add(s);
            }

            context.SaveChanges();

            Course[] courses = new Course[]
            {
                new Course{ CourseID = 2325, Title = "Mathematics", Credits = 7 },
                new Course{ CourseID = 2326, Title = "Physics", Credits = 6 },
                new Course{ CourseID = 2327, Title = "Chemistry", Credits = 7 },
                new Course{ CourseID = 2345, Title = "History", Credits = 5 }
            };

            foreach (Course c in courses)
            {
                context.Add(c);
            }

            context.SaveChanges();

            Enrollment[] enrollments = new Enrollment[]
            {
                new Enrollment{ StudentID = 1, CourseID = 2325, Grade = Grade.A },
                new Enrollment{ StudentID = 1, CourseID = 2345, Grade = Grade.B },
                new Enrollment{ StudentID = 2, CourseID = 2325, Grade = Grade.F },
                new Enrollment{ StudentID = 2, CourseID = 2345, Grade = Grade.A },
                new Enrollment{ StudentID = 2, CourseID = 2326, Grade = Grade.B },
                new Enrollment{ StudentID = 3, CourseID = 2325, Grade = Grade.A },
                new Enrollment{ StudentID = 4, CourseID = 2345, Grade = Grade.D },
                new Enrollment{ StudentID = 4, CourseID = 2325 },
                new Enrollment{ StudentID = 5, CourseID = 2326 },
                new Enrollment{ StudentID = 6, CourseID = 2325, Grade = Grade.E },
                new Enrollment{ StudentID = 7, CourseID = 2325, Grade = Grade.A },
                new Enrollment{ StudentID = 7, CourseID = 2325, Grade = Grade.A },
                new Enrollment{ StudentID = 8, CourseID = 2326, Grade = Grade.D },
                new Enrollment{ StudentID = 8, CourseID = 2325, Grade = Grade.F },
                new Enrollment{ StudentID = 8, CourseID = 2345 },
                new Enrollment{ StudentID = 9, CourseID = 2326, Grade = Grade.A },

            };

            foreach (Enrollment e in enrollments)
            {
                context.Add(e);
            }

            context.SaveChanges();
        }
    }
}
