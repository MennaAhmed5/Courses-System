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
    public partial class CourseSessionAttendenceForm : Form
    {
        public CourseSessionAttendenceForm()
        {
            InitializeComponent();
            NewFunc();
        }

        public CourseSessionAttendenceForm(int id) : this()
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

        CourseSessionAttendence courseSessionAttendence;
        MyDBContextApp db = new MyDBContextApp();


        void load(int id)
        {

            courseSessionAttendence = db.CourseSessionAttendence.First(c => c.Id == id);
            txt_id.Text = courseSessionAttendence.Id.ToString();
            txt_grade.Text = courseSessionAttendence.Grade.ToString();
            txt_notes.Text = courseSessionAttendence.Notes;
            txt_studentid.Text = courseSessionAttendence.StudentID.ToString();
            txt_courseSessionId.Text = courseSessionAttendence.CourseSessionId.ToString();
            IsNew = false;
        }

        void NewFunc()
        {
            courseSessionAttendence = new CourseSessionAttendence();
            txt_id.Text = "";
            txt_grade.Text = "";
            txt_notes.Text = "";
            txt_studentid.Text = "";
            txt_courseSessionId.Text = "";

            IsNew = true;
        }
        private void new_btn_Click(object sender, EventArgs e)
        {
            NewFunc();

        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            courseSessionAttendence.CourseSessionId = Convert.ToInt32(txt_courseSessionId.Text);
            if (!db.CourseSession.Any(cs => cs.Id == courseSessionAttendence.CourseSessionId))
            {
                MessageBox.Show("Please enter a valid courseSession id");
                return;
            }

            courseSessionAttendence.StudentID = Convert.ToInt32(txt_studentid.Text);
            if (!db.Student.Any(c => c.Id == courseSessionAttendence.StudentID))
            {
                MessageBox.Show("Please enter a valid student id");
                return;
            }

            

            courseSessionAttendence.Notes = txt_notes.Text;
            courseSessionAttendence.Grade = Convert.ToInt32(txt_grade.Text);


            if (IsNew)
            {
                db.CourseSessionAttendence.Add(courseSessionAttendence);
                await db.SaveChangesAsync();
                MessageBox.Show("CourseSessionAttedence Added...");
            }
            else
            {
                await db.SaveChangesAsync();
                MessageBox.Show("CourseSessionAttedence Updated...");
            }

          

            IsNew = false;
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            db.CourseSessionAttendence.Remove(courseSessionAttendence);
            db.SaveChanges();
            MessageBox.Show("courseSessionAttendence Deleted...");
        }
    }

       
 }

