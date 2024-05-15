using coursesProject.views;

namespace coursesProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm student = new StudentForm();
            student.ShowDialog();
        }



        private void viewStudensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentList studentList = new FormStudentList();
            studentList.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DepartmentForm department = new DepartmentForm();
            department.ShowDialog();
        }

        private void vewDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartmentList departmentList = new FormDepartmentList();
            departmentList.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InstructorForm instructor = new InstructorForm();
            instructor.ShowDialog();

        }

        private void viewInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInstructorList insructorList = new FormInstructorList();
            insructorList.ShowDialog();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CourseForm course = new CourseForm();
            course.ShowDialog();
        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourseList courseList = new FormCourseList();
            courseList.ShowDialog();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CourseStudentForm courseStudent = new CourseStudentForm();
            courseStudent.ShowDialog();
        }

        private void viewCourseStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourseStudentList courseStudentList = new FormCourseStudentList();
            courseStudentList.ShowDialog();
        }

        private void viewCourseSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourseSessionList courseSessionList = new FormCourseSessionList();
            courseSessionList.ShowDialog();
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CourseSessionForm courseSession = new CourseSessionForm();
            courseSession.ShowDialog();
        }

        private void addToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CourseSessionAttendenceForm courseSessionAttendence = new CourseSessionAttendenceForm();
            courseSessionAttendence.ShowDialog();
        }

        private void viewAllCourseSessionAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormCourseSessionAttendenceList courseSessionList = new FormCourseSessionAttendenceList();
            courseSessionList.ShowDialog();

        }
    }
}
