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
    public partial class StudentForm : Form
    {
        private Student Student
        {
            get
            {
                return (Student)this.propertyGrid1.SelectedObject;
            }
            set
            {
                this.propertyGrid1.SelectedObject = value;
            }
        }
        public StudentForm()
        {
            InitializeComponent();
            Student = new Student();
        }
        public StudentForm(Student student)
        {
            InitializeComponent();
            Student = student;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SchoolContext sc = new SchoolContext())
            {
                if (Student.Id > 0)
                {
                    sc.Students.Attach(Student);
                    var entry = sc.Entry<Student>(Student);
                    entry.State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    sc.Students.Add(Student);
                }
                sc.SaveChanges();
            }
            Close();
            
        }
    }
}
