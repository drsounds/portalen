using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portalen.Models
{
    public class Attendee
    {
        [Key, Column(Order = 0)]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public char Mark { get; set; }
    }
}
