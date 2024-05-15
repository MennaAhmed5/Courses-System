using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coursesProject.Entities;

namespace coursesProject.views
{
    public partial class StudentForm : Form
    {


        public StudentForm()
        {
            InitializeComponent();
            NewFunc();
        }

        public StudentForm(int id) : this()
        {
            load(id);

        }
         bool isNew;
        public bool IsNew { get => isNew; set
            {
                isNew = value;
                btn_save.Text = isNew? "Add" : "update";
                button2.Enabled = !isNew;
            }
        }
        Student student;
        MyDBContextApp db = new MyDBContextApp();

        
        void load(int id)
        {
           
            student = db.Student.First(c => c.Id == id);
            txt_Id.Text = student.Id.ToString();
            txt_Fname.Text = student.FirstName;
            txt_Lname.Text = student.LastName;
            txt_Phone.Text = student.Phone;
            IsNew = false;
        }
        
        void NewFunc()
        {
            student = new Student();
            txt_Fname.Text = "";
            txt_Id.Text = "";
            txt_Lname.Text = "";
            txt_Phone.Text = "";

            IsNew = true;
        }
        private void New_Click(object sender, EventArgs e)
        {
            NewFunc();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            
            student.FirstName = txt_Fname.Text;
            student.LastName = txt_Lname.Text;
            student.Phone = txt_Phone.Text;

        
            if (IsNew)
            {
                db.Student.Add(student);
                MessageBox.Show("Student Added...");
            }
            else
            {
                MessageBox.Show("Student Updated...");
            }
            
            await db.SaveChangesAsync();
            
            IsNew = false;
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (db.CourseStudent.Any(cs => cs.StudentId == student.Id)) {
                MessageBox.Show("You cannot delete this student because this student id exist in table CourseStudent !");
                return;
            }
            if(db.CourseSessionAttendence.Any(csa => csa.StudentID == student.Id))
            {
               MessageBox.Show("You cannot delete this student because this student id exist in table CourseSessionAttendence !");
                return;


            }
            db.Student.Remove(student);
            db.SaveChanges();
            MessageBox.Show("Student Deleted...");
        }
    }
}
