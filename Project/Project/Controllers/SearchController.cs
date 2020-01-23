using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class SearchController : Controller
    {
        
        public ActionResult Index(string searching)
        {
            mydbEntities db = new mydbEntities();
            return View(db.doctor_Register.Where(x=> x.city.Contains(searching) || searching==null).ToList());

        }
    }
}