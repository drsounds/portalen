using Portalen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portalen
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }
        private void LoadStudents()
        {
            listView1.Items.Clear();
            using(SchoolContext sc = new SchoolContext())
            {
                foreach (Student student in sc.Students)
                {
                    var item = listView1.Items.Add(student.LastName);
                    item.SubItems.Add(student.FirstName);
                    item.SubItems.Add(student.Address);
                    item.SubItems.Add(student.Zip);
                    item.SubItems.Add(student.City);
                    item.SubItems.Add(student.Phone);
                    item.SubItems.Add(student.Email);
                    item.SubItems.Add(student.SSN);
                    item.Tag = student;
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
        }
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.ShowDialog();
            this.LoadStudents();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                if (item.Tag != null)
                {
                    StudentForm sf = new StudentForm((Student)item.Tag);
                    sf.ShowDialog();
                    LoadStudents();
                }
            }
        }
    }
}
