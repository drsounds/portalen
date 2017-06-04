using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalen.Models
{
    public class Student : Person
    {
        public Student()
        {
            Attendees = new List<Attendee>();
        }
        public virtual ICollection<Attendee> Attendees { get; set; }
    }
}
