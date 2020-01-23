using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class DdController : Controller
    {
        mydbEntities db = new mydbEntities();
        public ActionResult Index()
        {
            return View(db.doctor_Register.ToList());
        }

        public ActionResult doctor_Register(int id)
        {
           
            return View(db.doctor_Register.Where(x => x.mob_Number == id).ToList());
        }
    }
}