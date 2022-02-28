using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAP_Project.Models
{
    public class StudentCourse
    {
        [Key]
        [Column(Order=1) ]
        public int StudentId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}