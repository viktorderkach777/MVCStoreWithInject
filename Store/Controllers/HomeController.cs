﻿using BusinessProjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyBll bll; 

        public HomeController(IMyBll bll)
        {
            this.bll = bll;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string Id)
        {
            return View("Index", (object)Id);
        }       


        public JsonResult JsonPlaces(PostPlace place)
        {
           
            string Id = place.Id;

            //if (Id != null)
            //{
            string[] words = place.Slider.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            words = words.Where(val => val != "-").ToArray();

            List<string> times = new List<string>();

            foreach (var item in words)
            {
                int pos = item.IndexOf(":00");
                times.Add(item.Remove(pos));
            }

           var icons = bll.GetDBPlacesByAllParams(Id, times[0], times[1], place.Rate);
            //}
            //else
            //{
            //    icons = _dal.GetDBPlacesByAllParams(Id, "12", "15", place.Rate);
            //}

            return Json(icons, JsonRequestBehavior.AllowGet);
        }
                          

        public ActionResult About()
        {
            return View();
        }       

        public ActionResult Contact()
        {           

            return View();
        }        
    }
}