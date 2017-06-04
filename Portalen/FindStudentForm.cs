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
    public partial class FindStudentForm : Form
    {
        public FindStudentForm()
        {
            InitializeComponent();
        }

        private void FindStudentForm_Load(object sender, EventArgs e)
        {

        }
        public Student SelectedStudent { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = tbFornamn.Text;
            String lastName = tbEfternamn.Text;
            string ssn = tbSSN.Text;
            listView1.Items.Clear();
            using (SchoolContext sc = new SchoolContext()) {
                IList<Student> students = sc.Students.Where(p => p.FirstName.Contains(firstName) || p.LastName.Contains(lastName) || p.SSN.Contains(ssn)).ToList();
                foreach(Student student in students)
                {
                    var item = listView1.Items.Add(student.SSN);
                    item.SubItems.Add(student.LastName);
                    item.SubItems.Add(student.FirstName);
                    item.Tag = (Student)student;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (listView1.SelectedItems.Count > 0)
            {
                SelectedStudent = (Student)listView1.SelectedItems[0].Tag;
            }
        }
    }
}
