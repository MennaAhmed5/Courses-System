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
    public partial class FormInstructorList : Form
    {
        public FormInstructorList()
        {
            InitializeComponent();
        }

        async void LoadInstructor()
        {
            load_btn.Enabled = false;
            MyDBContextApp db = new MyDBContextApp();
            var instructors = db.Instructor.AsQueryable();

            int id;
            if (int.TryParse(search_id.Text, out id) && id > 0)
            {
                instructors = instructors.Where(x => x.Id == id);

            }
            else if (search_fname.Text.Length > 0)
            {
                instructors = instructors.Where(x => x.FirstName.Contains(search_fname.Text.Trim()));

            }
            dataGridView1.DataSource = await instructors.ToListAsync();
            load_btn.Enabled = true;

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            LoadInstructor();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Instructor instructor)
            {
                int id = instructor.Id;
                InstructorForm frm = new InstructorForm(id);
                frm.ShowDialog();
                LoadInstructor();
            }
        }
    }
}
