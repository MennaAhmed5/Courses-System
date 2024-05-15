using coursesProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace coursesProject
{
    public partial class CourseSessionForm : Form
    {
        public CourseSessionForm()
        {
            InitializeComponent();
            NewFunc();
        }
        public CourseSessionForm(int id) : this()
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
        CourseSession courseSession;
        MyDBContextApp db = new MyDBContextApp();

        void load(int id)
        {

            courseSession = db.CourseSession.First(c => c.Id == id);
            txt_id.Text = courseSession.Id.ToString();
            txt_title.Text = courseSession.Title;
            txt_date.Text = courseSession.Date.ToString();
            txt_instructorId.Text = courseSession.InstructorID.ToString();
            txt_courseId.Text = courseSession.CourseID.ToString();
            IsNew = false;
        }

        void NewFunc()
        {
            courseSession = new CourseSession();
            txt_id.Text = "";
            txt_title.Text = "";
            txt_date.Text = "";
            txt_instructorId.Text = "";
            txt_courseId.Text = "";

            IsNew = true;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            NewFunc();
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            

                courseSession.Title = txt_title.Text;
               
                 courseSession.InstructorID = Convert.ToInt32(txt_instructorId.Text);
                if (!db.Instructor.Any(c => c.Id == courseSession.InstructorID))
                {
                   MessageBox.Show("Please enter a valid instructor id");
                   return;
                }
            
                courseSession.CourseID = Convert.ToInt32(txt_courseId.Text);
                if (!db.Course.Any(c => c.Id == courseSession.CourseID))
                {
                   MessageBox.Show("Please enter a valid course id");
                   return;
                }
                
                if (!DateTime.TryParseExact(txt_date.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                {
                  MessageBox.Show("Please enter a valid date in the format yyyy-MM-dd.");
                  return;
                }
               courseSession.Date = Convert.ToDateTime(txt_date.Text);

             if (IsNew)
                {
                    db.CourseSession.Add(courseSession);
                    await db.SaveChangesAsync();
                    MessageBox.Show("CourseSession Added...");
                }
                else
                {
                    await db.SaveChangesAsync();
                    MessageBox.Show("CourseSession Updated...");
                }

                IsNew = false;

            

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (db.CourseSessionAttendence.Any(csa => csa.CourseSessionId == courseSession.Id))
            {
                MessageBox.Show("You cannot delete this courseSession because this courseSession id exist in table CourseSessionAttendence!");
                return;
            }
            db.CourseSession.Remove(courseSession);
            db.SaveChanges();
            MessageBox.Show("CourseSession Deleted...");
        }

    }

       

         
    }

