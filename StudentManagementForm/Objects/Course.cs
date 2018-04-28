using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagementForm
{
    
    public class Course
    {
        public int? StudentID { get; set; }
        public int CourseID { get; set; }
        public int CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseTeacher { get; set; }
        
        public Course()
        {
           
        }
    }
}
