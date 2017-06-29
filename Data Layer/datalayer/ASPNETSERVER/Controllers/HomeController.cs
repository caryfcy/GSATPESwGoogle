﻿using ASPNETSERVER.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ASPNETSERVER.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public string Index()
        {
            return "Hello";
        }


        public JsonResult GetLatLongToUTM(float lat, float longt)//Creating Server and sending info 
        {
            LatLngUTMConverter lt = new LatLngUTMConverter(null);

            var result = lt.ArrResult(lat,longt);
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            /*for(var x in result) {

                for(var y in result)
                {

                }
            }*/
            var jsonResult = new { data = result};
          //  var jsonRes = new { arr = res };
            return Json(jsonResult, JsonRequestBehavior.AllowGet);

        }

        // GET: Index/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Index/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Index/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Index/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Index/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Index/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Index/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
