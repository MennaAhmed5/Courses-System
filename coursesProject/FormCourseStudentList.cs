using coursesProject.Entities;
using coursesProject.views;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormCourseStudentList : Form
    {
        public FormCourseStudentList()
        {
            InitializeComponent();
        }

        async void LoadCourseStudent()
        {
            btn_load.Enabled = false;
            MyDBContextApp db = new MyDBContextApp();
            var courseStudents = db.CourseStudent.AsQueryable();

            int stdId;
            int crsId;
            if (int.TryParse(search_studentId.Text, out stdId) && stdId > 0)
            {
                courseStudents = courseStudents.Where(x => x.StudentId == stdId);

            }
            else if (int.TryParse(search_courseid.Text, out crsId) && crsId > 0)
            {
                courseStudents = courseStudents.Where(x => x.CourseId == crsId);

            }
            dataGridView1.DataSource = await courseStudents.ToListAsync();
            btn_load.Enabled = true;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            LoadCourseStudent();

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is CourseStudent courseStudent)
            {
                int stdId = courseStudent.StudentId;
                int crsId = courseStudent.CourseId;
                CourseStudentForm frm = new CourseStudentForm(stdId, crsId);
                frm.ShowDialog();
                LoadCourseStudent();
            }
        }
    }
}
