using coursesProject.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
            NewFunc();
        }
        public DepartmentForm(string name) : this()
        {
            load(name);

        }
        bool isNew;
        public bool IsNew
        {
            get => isNew; set
            {
                isNew = value;
                Save_btn.Text = isNew ? "Add" : "update";
                delete_btn.Enabled = !isNew;
            }
        }
        Department department;
        MyDBContextApp db = new MyDBContextApp();

        void load(string name)
        {

            department = db.Department.First(c => c.Name == name);
            txt_name.Text = department.Name;
            txt_location.Text = department.Location;
            IsNew = false;
        }

        void NewFunc()
        {
            department = new Department();
            txt_name.Text = "";
            txt_location.Text = "";
            IsNew = true;
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            NewFunc();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (db.Instructor.Any(i => i.DepartmentName == department.Name))
            {
                MessageBox.Show("You cannot delete this department because this department id exist in table instructor!");
                return;
            }
            if (db.Course.Any(c => c.DepartmentName== department.Name))
            {
                MessageBox.Show("You cannot delete this department because this department id exist in table Course !");
                return;


            }


            db.Department.Remove(department);
            db.SaveChanges();
            MessageBox.Show("Department Deleted...");
        }

        private async void Save_btn_Click(object sender, EventArgs e)
        {
            department.Name = txt_name.Text;

            if (db.Department.Any(d => d.Name == department.Name))
            {
                MessageBox.Show("This Department Already Exsit");
                return;


            }
            department.Location = txt_location.Text;
             


            if (IsNew)
            {
                db.Department.Add(department);
                MessageBox.Show("Department Added...");
            }
            else
            {
                MessageBox.Show("Department Updated...");
            }

            await db.SaveChangesAsync();

            IsNew = false;
        }
    }
}
