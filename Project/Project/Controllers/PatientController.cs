using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;


namespace Project.Controllers
{
    public class PatientController : Controller
    {
        [HttpGet]
        public ActionResult AddorEdit(int id=0)
        {
            patient_Register patient_Register = new patient_Register();
            return View(patient_Register);
        }

        [HttpPost]
        public ActionResult AddorEdit(patient_Register patient_Register)
        {
            using(DbModel dbModel = new DbModel())
            {
                if(dbModel.patient_Register.Any(x => x.mob_Number == patient_Register.mob_Number))
                {
                    ViewBag.DuplicateMessage = "mobile number already exits";
                    return View("AddorEdit", patient_Register);
                }
                
                dbModel.patient_Register.Add(patient_Register);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration SuccessFull";
            return View("AddorEdit", new patient_Register());
        }

    }
}