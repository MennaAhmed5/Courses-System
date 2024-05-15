using coursesProject.Entities;
using Microsoft.VisualBasic.Devices;
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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            NewFunc();
        }
        public CourseForm(int id) : this()
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
        Course course;
        MyDBContextApp db = new MyDBContextApp();

        void load(int id)
        {

            course = db.Course.First(c => c.Id == id);
            txt_id.Text = course.Id.ToString();
            txt_name.Text = course.Name;
            txt_duration.Text = course.Duration.ToString();
            txt_deptname.Text = course.DepartmentName;
            txt_instructorid.Text = course.InstructorId.ToString();
            IsNew = false;
        }

        void NewFunc()
        {
            course = new Course();
            txt_id.Text = "";
            txt_name.Text = "";
            txt_deptname.Text = "";
            txt_duration.Text = "";
            txt_instructorid.Text = "";

            IsNew = true;
        }
        private void new_btn_Click(object sender, EventArgs e)
        {
            NewFunc();
        }

        private async void  save_btn_Click(object sender, EventArgs e)
        {
             
                course.Duration = Convert.ToInt32(txt_duration.Text);

                course.DepartmentName = txt_deptname.Text;
                if (!db.Department.Any(d => d.Name == course.DepartmentName))
                {
                MessageBox.Show("Please enter a valid department name");
                return;
                }
                course.InstructorId = Convert.ToInt32(txt_instructorid.Text);
                
               if (!db.Instructor.Any(i => i.Id == course.InstructorId)) {
                  MessageBox.Show("Please enter a valid instructor id");
                 return;
               }
                    
                course.Name = txt_name.Text;
               


            if (IsNew)
                {
                    db.Course.Add(course);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Course Added...");
                }
                else
                {
                    await db.SaveChangesAsync();
                    MessageBox.Show("Course Updated...");
                }

                

                IsNew = false;

            
             
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (db.CourseSession.Any(cs => cs.CourseID == course.Id))
            {
                MessageBox.Show("You cannot delete this course because this course id exist in table courseSession!");
                return;
            }
            if (db.CourseStudent.Any(cs => cs.CourseId == course.Id))
            {
                MessageBox.Show("You cannot delete this course because this course id exist in table CourseStudent !");
                return;


            }
            db.Course.Remove(course);
            db.SaveChanges();
            MessageBox.Show("Course Deleted...");
        }
    }
}
