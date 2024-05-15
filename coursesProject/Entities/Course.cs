using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursesProject.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }

        public string Name { get; set; }

        //foreign keys
        public string DepartmentName { get; set; }

        public int InstructorId { get; set; }

        //reference
        public Department Department { get; set; }

        public Instructor Instructor { get; set; }
    }
}
