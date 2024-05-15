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
    public partial class FormDepartmentList : Form
    {
        public FormDepartmentList()
        {
            InitializeComponent();
        }


        async void LoadDepartment()
        {
            load_btn.Enabled = false;
            MyDBContextApp db = new MyDBContextApp();
            var departments = db.Department.AsQueryable();



            if (search_name.Text.Length>0)
            {
                departments = departments.Where(x => x.Name.Contains(search_name.Text.Trim()));

            }
            else if (search_Location.Text.Length > 0)
            {
                departments = departments.Where(x => x.Location.Contains(search_Location.Text.Trim()));

            }
            dataGridView1.DataSource = await departments.ToListAsync();
            load_btn.Enabled = true;



        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Department department)
            {
                string name = department.Name;
                DepartmentForm frm = new DepartmentForm(name);
                frm.ShowDialog();
                LoadDepartment();
            }
        }

         
    }
}
