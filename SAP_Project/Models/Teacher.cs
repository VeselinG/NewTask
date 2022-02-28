using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAP_Project.Models
{
    public class Teacher
    {

        public Teacher()
        {
            this.Courses = new HashSet<Course>();
        }

        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherTitle { get; set; }

        public virtual ICollection<Course> Courses { get; set; }


    }
}