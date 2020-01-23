using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;
namespace Project.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
       

        public ActionResult Details(int Id)
        {
            doctor_Register frnds = new doctor_Register();
             mydbEntities db = new mydbEntities();
            frnds = db.doctor_Register.Find(Id);
            return PartialView("_Details", frnds);
        }

        public ActionResult Index(string searching)
        {
            mydbEntities db = new mydbEntities();
            return View(db.doctor_Register.Where(x => x.city.Contains(searching) || searching == null).ToList());

        }
    }
}