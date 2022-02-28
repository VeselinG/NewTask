using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAP_Project.Models
{
    public class PresentModels
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<StudentCourse> StudentCourses { get; set; }
    }
}