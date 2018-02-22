using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public string Fees(int id = 923073 , string name = "Khurram" ) 
        {
            var yes = "yes";
            var feespay = yes;
           
            if (feespay == yes)
            {
                return "You are allowed to take classes";
            }
            else
            {
                return "You are not allowed to take classes becouse your fess is not payed";
            }
        }
    }
}