using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAP_Project.Models
{
    public class Student
    {
        public Student()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentCourseYear { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}