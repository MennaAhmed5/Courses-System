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
    public partial class FormCourseSessionAttendenceList : Form
    {
        public FormCourseSessionAttendenceList()
        {
            InitializeComponent();
        }
        async void LoadCourseSessionAttendence()
        {
            load_btn.Enabled = false;
            MyDBContextApp db = new MyDBContextApp();
            var courseSessionAttendences = db.CourseSessionAttendence.AsQueryable();

            int id;
            int grade;
            if (int.TryParse(search_id.Text, out id) && id > 0)
            {
                courseSessionAttendences = courseSessionAttendences.Where(x => x.Id == id);

            }
            else if (search_note.Text.Length > 0)
            {
                courseSessionAttendences = courseSessionAttendences.Where(x => x.Notes.Contains(search_note.Text.Trim()));

            }
            dataGridView1.DataSource = await courseSessionAttendences.ToListAsync();
            load_btn.Enabled = true;

        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            LoadCourseSessionAttendence();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is CourseSessionAttendence courseSessionAttendence)
            {
                int id = courseSessionAttendence.Id;
                CourseSessionAttendenceForm frm = new CourseSessionAttendenceForm(id);
                frm.ShowDialog();
                LoadCourseSessionAttendence();
            }
        }
    }
}
