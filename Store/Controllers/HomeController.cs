using BusinessProjectLayer;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyBll bll = new MyBll();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //string mark = "sdd";
           

            return View();
        }

        [HttpPost]
        public ActionResult About(AboutViewModel model)
        {            
            var result = bll.GetProducersCountByConcreteMark(model.ConcreteMark);
            model.Quantity = result;          

            return View(model);
        }

        public ActionResult Contact()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            model.Countries = bll.GetCountriesByConcreteMark(model.ConcreteMark);

            return View(model);
        }
    }
}