namespace coursesProject
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            viewStudensToolStripMenuItem = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            vewDepartmentsToolStripMenuItem = new ToolStripMenuItem();
            instructorToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem2 = new ToolStripMenuItem();
            viewInstructorsToolStripMenuItem = new ToolStripMenuItem();
            courseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem3 = new ToolStripMenuItem();
            viewCoursesToolStripMenuItem = new ToolStripMenuItem();
            courseStudenToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem4 = new ToolStripMenuItem();
            viewCourseStudentToolStripMenuItem = new ToolStripMenuItem();
            courseSessionToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem5 = new ToolStripMenuItem();
            viewCourseSessionsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            courseSessionAttendenceToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem6 = new ToolStripMenuItem();
            viewAllCourseSessionAttendenceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, departmentToolStripMenuItem, instructorToolStripMenuItem, courseToolStripMenuItem, courseStudenToolStripMenuItem, courseSessionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, viewStudensToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(89, 29);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(270, 34);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // viewStudensToolStripMenuItem
            // 
            viewStudensToolStripMenuItem.Name = "viewStudensToolStripMenuItem";
            viewStudensToolStripMenuItem.Size = new Size(270, 34);
            viewStudensToolStripMenuItem.Text = "View Students";
            viewStudensToolStripMenuItem.Click += viewStudensToolStripMenuItem_Click;
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, vewDepartmentsToolStripMenuItem });
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(123, 29);
            departmentToolStripMenuItem.Text = "Department";
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(270, 34);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // vewDepartmentsToolStripMenuItem
            // 
            vewDepartmentsToolStripMenuItem.Name = "vewDepartmentsToolStripMenuItem";
            vewDepartmentsToolStripMenuItem.Size = new Size(270, 34);
            vewDepartmentsToolStripMenuItem.Text = "View Departments";
            vewDepartmentsToolStripMenuItem.Click += vewDepartmentsToolStripMenuItem_Click;
            // 
            // instructorToolStripMenuItem
            // 
            instructorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem2, viewInstructorsToolStripMenuItem });
            instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            instructorToolStripMenuItem.Size = new Size(104, 29);
            instructorToolStripMenuItem.Text = "Instructor";
            // 
            // addToolStripMenuItem2
            // 
            addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            addToolStripMenuItem2.Size = new Size(240, 34);
            addToolStripMenuItem2.Text = "Add";
            addToolStripMenuItem2.Click += addToolStripMenuItem2_Click;
            // 
            // viewInstructorsToolStripMenuItem
            // 
            viewInstructorsToolStripMenuItem.Name = "viewInstructorsToolStripMenuItem";
            viewInstructorsToolStripMenuItem.Size = new Size(240, 34);
            viewInstructorsToolStripMenuItem.Text = "View Instructors";
            viewInstructorsToolStripMenuItem.Click += viewInstructorsToolStripMenuItem_Click;
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem3, viewCoursesToolStripMenuItem });
            courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            courseToolStripMenuItem.Size = new Size(83, 29);
            courseToolStripMenuItem.Text = "Course";
            // 
            // addToolStripMenuItem3
            // 
            addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            addToolStripMenuItem3.Size = new Size(219, 34);
            addToolStripMenuItem3.Text = "Add";
            addToolStripMenuItem3.Click += addToolStripMenuItem3_Click;
            // 
            // viewCoursesToolStripMenuItem
            // 
            viewCoursesToolStripMenuItem.Name = "viewCoursesToolStripMenuItem";
            viewCoursesToolStripMenuItem.Size = new Size(219, 34);
            viewCoursesToolStripMenuItem.Text = "View Courses";
            viewCoursesToolStripMenuItem.Click += viewCoursesToolStripMenuItem_Click;
            // 
            // courseStudenToolStripMenuItem
            // 
            courseStudenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem4, viewCourseStudentToolStripMenuItem });
            courseStudenToolStripMenuItem.Name = "courseStudenToolStripMenuItem";
            courseStudenToolStripMenuItem.Size = new Size(151, 29);
            courseStudenToolStripMenuItem.Text = "Course_Student";
            // 
            // addToolStripMenuItem4
            // 
            addToolStripMenuItem4.Name = "addToolStripMenuItem4";
            addToolStripMenuItem4.Size = new Size(272, 34);
            addToolStripMenuItem4.Text = "Add";
            addToolStripMenuItem4.Click += addToolStripMenuItem4_Click;
            // 
            // viewCourseStudentToolStripMenuItem
            // 
            viewCourseStudentToolStripMenuItem.Name = "viewCourseStudentToolStripMenuItem";
            viewCourseStudentToolStripMenuItem.Size = new Size(272, 34);
            viewCourseStudentToolStripMenuItem.Text = "View CourseStudent";
            viewCourseStudentToolStripMenuItem.Click += viewCourseStudentToolStripMenuItem_Click;
            // 
            // courseSessionToolStripMenuItem
            // 
            courseSessionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem5, viewCourseSessionsToolStripMenuItem });
            courseSessionToolStripMenuItem.Name = "courseSessionToolStripMenuItem";
            courseSessionToolStripMenuItem.Size = new Size(143, 29);
            courseSessionToolStripMenuItem.Text = "CourseSession";
            // 
            // addToolStripMenuItem5
            // 
            addToolStripMenuItem5.Name = "addToolStripMenuItem5";
            addToolStripMenuItem5.Size = new Size(279, 34);
            addToolStripMenuItem5.Text = "Add";
            addToolStripMenuItem5.Click += addToolStripMenuItem5_Click;
            // 
            // viewCourseSessionsToolStripMenuItem
            // 
            viewCourseSessionsToolStripMenuItem.Name = "viewCourseSessionsToolStripMenuItem";
            viewCourseSessionsToolStripMenuItem.Size = new Size(279, 34);
            viewCourseSessionsToolStripMenuItem.Text = "View CourseSessions";
            viewCourseSessionsToolStripMenuItem.Click += viewCourseSessionsToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { courseSessionAttendenceToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 33);
            menuStrip2.TabIndex = 9;
            menuStrip2.Text = "menuStrip2";
            // 
            // courseSessionAttendenceToolStripMenuItem
            // 
            courseSessionAttendenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem6, viewAllCourseSessionAttendenceToolStripMenuItem });
            courseSessionAttendenceToolStripMenuItem.Name = "courseSessionAttendenceToolStripMenuItem";
            courseSessionAttendenceToolStripMenuItem.Size = new Size(233, 29);
            courseSessionAttendenceToolStripMenuItem.Text = "CourseSessionAttendence";
            // 
            // addToolStripMenuItem6
            // 
            addToolStripMenuItem6.Name = "addToolStripMenuItem6";
            addToolStripMenuItem6.Size = new Size(361, 34);
            addToolStripMenuItem6.Text = "Add";
            addToolStripMenuItem6.Click += addToolStripMenuItem6_Click;
            // 
            // viewAllCourseSessionAttendenceToolStripMenuItem
            // 
            viewAllCourseSessionAttendenceToolStripMenuItem.Name = "viewAllCourseSessionAttendenceToolStripMenuItem";
            viewAllCourseSessionAttendenceToolStripMenuItem.Size = new Size(361, 34);
            viewAllCourseSessionAttendenceToolStripMenuItem.Text = "View CourseSessionAttendence";
            viewAllCourseSessionAttendenceToolStripMenuItem.Click += viewAllCourseSessionAttendenceToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 281);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem viewStudensToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem vewDepartmentsToolStripMenuItem;
        private ToolStripMenuItem instructorToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem2;
        private ToolStripMenuItem viewInstructorsToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem3;
        private ToolStripMenuItem viewCoursesToolStripMenuItem;
        private ToolStripMenuItem courseStudenToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem4;
        private ToolStripMenuItem viewCourseStudentToolStripMenuItem;
        private ToolStripMenuItem courseSessionToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem5;
        private ToolStripMenuItem viewCourseSessionsToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem courseSessionAttendenceToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem6;
        private ToolStripMenuItem viewAllCourseSessionAttendenceToolStripMenuItem;
    }
}
