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
    public partial class CourseStudentForm : Form
    {
        public CourseStudentForm()
        {
            InitializeComponent();
            NewFunc();
        }

        public CourseStudentForm(int stdId, int crsId) : this()
        {
            load(stdId, crsId);

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
        CourseStudent courseStudent;
        MyDBContextApp db = new MyDBContextApp();

        void load(int stdId, int crsId)
        {

            courseStudent = db.CourseStudent.First(cs => cs.StudentId == stdId && cs.CourseId == crsId);
            txt_courseid.Text = courseStudent.CourseId.ToString();
            txt_studentid.Text = courseStudent.StudentId.ToString();
            IsNew = false;
        }

        void NewFunc()
        {
            courseStudent = new CourseStudent();
            txt_courseid.Text = "";
            txt_studentid.Text = "";
            IsNew = true;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            NewFunc();
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {

              courseStudent.CourseId = Convert.ToInt32(txt_courseid.Text);
              if (!db.Course.Any(c => c.Id == courseStudent.CourseId))
              {
                MessageBox.Show("Please enter a valid Course Id");
                return;
               }
              courseStudent.StudentId = Convert.ToInt32(txt_studentid.Text);
              if (!db.Student.Any(s=> s.Id == courseStudent.StudentId))
               {
                MessageBox.Show("Please enter a valid Student Id");
                return;
               }
                
               if(db.CourseStudent.Any(cs=>cs.StudentId == courseStudent.StudentId)&& db.CourseStudent.Any(cs => cs.CourseId == courseStudent.CourseId))
               {
                MessageBox.Show("Student Id and Course Id Already exist");
                return;

            }


                if (IsNew)
                {
                    db.CourseStudent.Add(courseStudent);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Course_Student Added...");
                   
                }
                else
                {
                   // await db.SaveChangesAsync();
                    MessageBox.Show("Course Id and Student Id cannot be modeified becaus they are composite primary key...");
                    
                }

                IsNew = false;
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            db.CourseStudent.Remove(courseStudent);
            db.SaveChanges();
            MessageBox.Show("Course_Student Deleted...");
        }
    }
}
