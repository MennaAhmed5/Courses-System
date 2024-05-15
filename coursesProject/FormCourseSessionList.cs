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
    public partial class FormCourseSessionList : Form
    {
        public FormCourseSessionList()
        {
            InitializeComponent();
        }
        async void LoadCourseSession()
        {

            btn_load.Enabled = false;
            MyDBContextApp db = new MyDBContextApp();
            var courseSessions = db.CourseSession.AsQueryable();

            int id;
            if (int.TryParse(search_id.Text, out id) && id > 0)
            {
                courseSessions = courseSessions.Where(x => x.Id == id);

            }
            else if (search_title.Text.Length > 0)
            {
                courseSessions = courseSessions.Where(x => x.Title.Contains(search_title.Text.Trim()));

            }
            dataGridView1.DataSource = await courseSessions.ToListAsync();
            btn_load.Enabled = true;

        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadCourseSession();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is CourseSession courseSession)
            {
                int id = courseSession.Id;
                CourseSessionForm frm = new CourseSessionForm(id);
                frm.ShowDialog();
                LoadCourseSession();
            }
        }
    }
}
