using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{
    public class AdmissionController : Controller
    {
        // GET: Admission
        
          public string Index(string name = "Khurram")
        {
            string batch = "201510C";
            var id = 923073;
            var yes = "yes";
            var alive = yes;
            
            if (alive == yes)

                return name+" You are enrolled in "+batch+" and your id is "+id;
            else

                return name + " Sorry We are not able to enrolle you because your not alive ";
        }
        public string CancelAdmission(int id = 923073 , string name = "Khurram")
        {
            return "Your Admission is cancelled";
        }
    }
}