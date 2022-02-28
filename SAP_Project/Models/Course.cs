using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAP_Project.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}