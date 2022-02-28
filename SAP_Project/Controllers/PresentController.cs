using SAP_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAP_Project.Controllers
{
    public class PresentController : Controller
    {
        private CreateDbContext db = new CreateDbContext();
        private PresentModels currentView = new PresentModels();       
        

        public ActionResult Index()
        {
            return View();
        }
        // GET: Present
        public ActionResult GetAll()
        {
            
            currentView.Teachers = db.Teachers.ToList().OrderBy(x=>x.TeacherName);
            currentView.Students = db.Student.ToList().OrderBy(x=>x.StudentName);
            return View(currentView);
        }

        public ActionResult GetStudentCource()
        {
            currentView.Students = db.Student.ToList().OrderBy(x => x.StudentName);
            currentView.StudentCourses = db.StudentCourse.ToList();
           
            return View(currentView);
        }

        public ActionResult GetStudentCredits()
        {
            currentView.Students = db.Student.ToList().OrderBy(x => x.StudentName);
            currentView.StudentCourses = db.StudentCourse.ToList();

            return View(currentView);
        }

        public ActionResult GetTeacherInfo()
        {
            currentView.Students = db.Student.ToList();
            currentView.Teachers = db.Teachers.ToList();
            currentView.StudentCourses = db.StudentCourse.ToList();

            return View(currentView);
        }

        public ActionResult GetFirstThreeCources()
        {
            currentView.Courses = db.Course.OrderByDescending(x => x.StudentCourses.Count).Take(3).ToList();

            return View(currentView);
        }
    }
}