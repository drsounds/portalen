using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Portalen.Models;

namespace Portalen
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public void EnrollStudent(Student student, Course course)
        {
            Attendee attendee = new Attendee();
            attendee.CourseId = course.Id;
            attendee.StudentId = student.Id;
            this.Attendees.Add(attendee);
        }

    }
}
