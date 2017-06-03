using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portalen.Models;
namespace Portalen
{
    public partial class AttendeesForm : Form
    {
        public AttendeesForm()
        {
            InitializeComponent();
        }
        public void LoadAttendees()
        {
            listView1.Items.Clear();
            using (SchoolContext sc = new SchoolContext())
            {
                List<Attendee> attendees = sc.Attendees.ToList();
                foreach(Attendee attendee in attendees)
                {
                    var item = listView1.Items.Add("");
                    item.SubItems.Add(attendee.Student.Name);
                    item.SubItems.Add(attendee.Course.Name);
                }
            }
        }
        private void AttendeesForm_Load(object sender, EventArgs e)
        {
            LoadAttendees();
        }
    }
}
