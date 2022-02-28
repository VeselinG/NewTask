using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SAP_Project.Models;

namespace SAP_Project.Controllers
{
    public class StudentCoursesController : Controller
    {
        private CreateDbContext db = new CreateDbContext();

        // GET: StudentCourses
        public ActionResult Index()
        {
            var studentCourse = db.StudentCourse.Include(s => s.Course).Include(s => s.Student);
            return View(studentCourse.ToList());
        }

        

        // GET: StudentCourses/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Course, "CourseId", "CourseName");
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName");
            return View();
        }

        // POST: StudentCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,CourseId")] StudentCourse studentCourse)
        {
            if (ModelState.IsValid)
            {
                db.StudentCourse.Add(studentCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Course, "CourseId", "CourseName", studentCourse.CourseId);
            ViewBag.StudentId = new SelectList(db.Student, "StudentId", "StudentName", studentCourse.StudentId);
            return View(studentCourse);
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
