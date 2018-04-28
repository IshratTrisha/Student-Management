using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagementForm
{
    public class Student
    {
       
        public int StudentID { get; set; }
        public int SerialNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Group { get; set; }

        public List<Course> Courses { get; set; }


        public Student()
        {

        }
    }

}
