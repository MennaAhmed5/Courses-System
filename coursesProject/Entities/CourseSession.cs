using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursesProject.Entities
{
    public class CourseSession
    {
        public int Id { get; set; }
        public int CourseID { get; set; }
        public int InstructorID { get; set; }

        public DateTime Date { get; set; }
        public string Title { get; set; }

        //references 

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
