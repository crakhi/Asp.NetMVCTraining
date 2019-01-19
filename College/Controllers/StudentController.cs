using College.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace College.Controllers
{
    public class StudentController : Controller
    {


        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Details()
        {
            //return Content("Hey I'm rama! " + System.DateTime.Now.ToLongTimeString());

            //Get data from database
            List<StudentModel> studentsData = getDataFromDatabase();
            return View(studentsData);
        }


        

        private List<StudentModel> getDataFromDatabase()
        {
            //Connect to database

            List<StudentModel> students = new List<StudentModel> {

                new StudentModel{ Id=1, City="<script>alert('hello')</script>", Class="9", Name="rama", rollno=10 },
                new StudentModel{ Id=2, City="Banglore", Class="1", Name="krishna", rollno=11 },
                new StudentModel{ Id=3, City="Delhi", Class="5", Name="chowdary", rollno=12 },
                new StudentModel{ Id=4, City="Hyderabad", Class="6", Name="chitturi", rollno=13 },

            };

            return students;

        }
    }
}