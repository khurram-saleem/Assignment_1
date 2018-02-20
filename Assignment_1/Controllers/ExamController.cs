using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public string Index(int Id = 923073, string batch = "201510C")
        {
            int Attendence = 80;
            int ReqAttendence = 75;

            if (Attendence > ReqAttendence)

                return Id+" Your Exam is scheduled";
            else

                return Id+" We are not able to schedule Exam for you because your Attendence is "+Attendence+"% and required Attendence is "+ReqAttendence+"%";
        }

        
    }
}