using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursesProject.Entities
{
    public class CourseSessionAttendence
    {
        public int Id { get; set; }
        public string Notes { get; set; }
   

        public int Grade { get; set; }

        public int CourseSessionId { get; set; }
        public int StudentID { get; set; }

        //References
        public CourseSession CourseSession { get; set; }
        public Student Student { get; set; }
    }
}
