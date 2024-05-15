using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursesProject.Entities
{
    public class CourseStudent
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }


        //optional
        public Course Course { get; set; }
        public Student Student { get; set; }


     }
}
