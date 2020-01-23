using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Models;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class doctorregisterController : Controller
    {
        [HttpGet]
        public ActionResult DoctorRegister(int id = 0)
        {
            doctor_Register dreg = new doctor_Register();
            return View(dreg);
        }


        [HttpPost]

        public ActionResult DoctorRegister(doctor_Register doctor_Register)
        {
            using (mydbEntities mydbEntities=new mydbEntities())
            {
                if(mydbEntities.doctor_Register.Any(x => x.mob_Number == doctor_Register.mob_Number))
                {
                    ViewBag.DuplicateMessage = "mobile number already exits";
                    return View("DoctorRegister", new doctor_Register());
                }
                mydbEntities.doctor_Register.Add(doctor_Register);
                mydbEntities.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration SuccessFull";
            return View("DoctorRegister", new doctor_Register());
            
        }

    }
        
  
}