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
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        public void LoadCourses()
        {
            listView1.Items.Clear();
            using(SchoolContext sc = new SchoolContext())
            {
               foreach(Course c in sc.Courses)
                {
                    var item = listView1.Items.Add(c.Name);
                    item.SubItems.Add(c.Code);
                    item.SubItems.Add(c.Id.ToString());
                    item.Tag = c;
                }
            }
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CourseForm cf = new Portalen.CourseForm();
            
            cf.ShowDialog();
            LoadCourses();

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var item = listView1.SelectedItems[0].Tag;
            if (item != null)
            {
                CourseForm cf = new CourseForm((Course)item);
                cf.ShowDialog();
                LoadCourses();
            }
        }
    }
}
