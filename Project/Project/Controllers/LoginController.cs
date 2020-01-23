using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(patient_Register patient_Register)
        {
            using (DbModel db=new DbModel())
            {
                var userDetails = db.patient_Register.Where(x => x.mob_Number == patient_Register.mob_Number && x.password == patient_Register.password).FirstOrDefault();
                if(userDetails == null)
                {
                    patient_Register.LoginErrorMessage = "Wrong  user name or password.";
                    return View("Index",patient_Register);
                }
                else
                {
                    Session["UserID"] = userDetails.mob_Number;
                    return RedirectToAction("Index", "DashBoard");
                }
            }
               
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}