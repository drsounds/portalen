using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Portalen.Models
{
    public class Course
    {
        public Course()
        {
            this.Attendants = new List<Attendee>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Attendee> Attendants { get; set; }
        public IEnumerable<Student> Students {
            get
            {
                return Attendants?.Select(p => p.Student);
            }
        }
    }
}
