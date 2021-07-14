using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Portal_Global.Controllers
{
    [EnableCors()]
    public class PortalController : Controller
    {
        // GET: Portal
        public ActionResult Index()
        {
            try
            {
                ViewBag.IP = GetIP();
                Usuario UserData = (Usuario)Session["UserData"];
                if (UserData != null && UserData.UserName != null && UserData.UserName != "")
                {
                    ViewBag.User = UserData;
                    //ViewBag.ObjUser = UserData;
                    return View(UserData);
                }
                else
                {
                    //return Redirect("../LoginPortal");
                    return View("~/Views/LoginPortal/Index.cshtml");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
           
        }
        public string GetIP()
        {
            IPHostEntry host;
            var ipApp= "127.0.0.1";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipApp= ip.ToString();

                }
                
            }
            return ipApp;

        }


    }
}
