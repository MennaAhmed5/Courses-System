using coursesProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursesProject
{
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
            NewFunc();
        }

        public InstructorForm(int id) : this()
        {
            load(id);

        }
        bool isNew;
        public bool IsNew
        {
            get => isNew; set
            {
                isNew = value;
                save_btn.Text = isNew ? "Add" : "update";
                delete_btn.Enabled = !isNew;
            }
        }
        Instructor instructor;
        MyDBContextApp db = new MyDBContextApp();

        void load(int id)
        {

            instructor = db.Instructor.First(c => c.Id == id);
            txt_id.Text = instructor.Id.ToString();
            txt_fname.Text = instructor.FirstName;
            txt_lname.Text = instructor.LastName;
            txt_phone.Text = instructor.Phone;
            txt_deptName.Text = instructor.DepartmentName;
            IsNew = false;
        }

        void NewFunc()
        {
            instructor = new Instructor();
            txt_fname.Text = "";
            txt_id.Text = "";
            txt_lname.Text = "";
            txt_phone.Text = "";
            txt_deptName.Text = "";

            IsNew = true;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            NewFunc();
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
             
                instructor.FirstName = txt_fname.Text;
                instructor.LastName = txt_lname.Text;
                instructor.DepartmentName = txt_deptName.Text;
               if (!db.Department.Any(d => d.Name == instructor.DepartmentName))
                {
                MessageBox.Show("PLease Enter a valid department name...");
                return;
                }
                 
                
                instructor.Phone = txt_phone.Text;


                if (IsNew)
                {
                    db.Instructor.Add(instructor);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Instructor Added...");
                }
                else
                {
                    MessageBox.Show("Instructor Updated...");
                    await db.SaveChangesAsync();
                }

                

                IsNew = false;
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (db.CourseSession.Any(cs => cs.InstructorID == instructor.Id))
            {
                MessageBox.Show("You cannot delete this instructor because this instructor id exist in table CourseSession!");
                return;
            }
            if (db.Course.Any(c => c.InstructorId == instructor.Id))
            {
                MessageBox.Show("You cannot delete this instructor because this instructor id exist in table Course !");
                return;


            }
            db.Instructor.Remove(instructor);
            db.SaveChanges();
            MessageBox.Show("Instructor Deleted...");
        }
    }
}
