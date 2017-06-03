using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalen.Models
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SSN { get; set; }
    }
}
