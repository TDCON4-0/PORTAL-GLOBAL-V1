using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal_Global.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Home()
        {
            try
            {
                return View("../Home/Home");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            //[LocalizedView("en")]
            //public ActionResult Prueba()
            //{
            //    return View("About");
            //}



        }
    }
}