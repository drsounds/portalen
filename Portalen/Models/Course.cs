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
            this.Attendees = new List<Attendee>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Attendee> Attendees { get; set; }
    }
}
