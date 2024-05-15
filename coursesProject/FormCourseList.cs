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
    public partial class FormCourseList : Form
    {
        public FormCourseList()
        {
            InitializeComponent();
        }


        async void LoadCourse()
        {
            load_btn.Enabled = false;
            MyDBContextApp db = new MyDBContextApp();
            var courses = db.Course.AsQueryable();

            int id;
            if (int.TryParse(search_id.Text, out id) && id > 0)
            {
                courses = courses.Where(x => x.Id == id);

            }
            else if (search_name.Text.Length > 0)
            {
                courses = courses.Where(x => x.Name.Contains(search_name.Text.Trim()));

            }
            dataGridView1.DataSource = await courses.ToListAsync();
            load_btn.Enabled = true;



        }
         

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Course course)
            {
                int id = course.Id;
                CourseForm frm = new CourseForm(id);
                frm.ShowDialog();
                LoadCourse();
             }
        }

        private void load_btn_Click_1(object sender, EventArgs e)
        {
            LoadCourse();
         
        }
    }
}
