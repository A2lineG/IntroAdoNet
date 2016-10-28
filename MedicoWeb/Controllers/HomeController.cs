using MedicoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoWeb.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            HoraireModel h = new HoraireModel();
            List<HoraireModel> lm = h.GetAll();

            return View(lm);
        }
       
    }
}