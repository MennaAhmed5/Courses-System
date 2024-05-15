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
    public partial class FormStudentList : Form
    {
        public FormStudentList()
        {
            InitializeComponent();
        }

        async void  LoadStudent()
        {
            button2.Enabled = false;
            MyDBContextApp db = new MyDBContextApp();
            var students = db.Student.AsQueryable();

            int id;
            if (int.TryParse(Search_id.Text, out id) && id > 0)
            {
                students = students.Where(x => x.Id == id);

            } else if (Search_name.Text.Length>0)
            {
                students = students.Where(x => x.FirstName.Contains(Search_name.Text.Trim()));

            }
             dataGridView1.DataSource = await students.ToListAsync();
             button2.Enabled = true;



        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.DataBoundItem is Student student)
            {
                int id = student.Id;
                StudentForm frm = new StudentForm(id);
                frm.ShowDialog();
                LoadStudent();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }
    }
}
