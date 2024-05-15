using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursesProject.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        //id 
        public string DepartmentName { get; set; }

        //reference
        public Department Department { get; set; }
 




    }
}
