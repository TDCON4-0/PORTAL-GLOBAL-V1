using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal_Global.Controllers
{
    public class LoginPortalController : Controller
    {
        // GET: LoginPortal
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult setLogin(Usuario usuario)
        {
            try
            {
                //optiene todos los logs de operacion de una vista
                Session.Add("UserData", usuario);
                var x =Session["UserData"];
                HttpCookie cookie = new HttpCookie("UserName","Login");
                ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                return Json(Session["UserData"], JsonRequestBehavior.AllowGet);



            }
            catch (Exception e)
            {
                var mensaje = new Mensajes();
                mensaje.Mensaje = e.Message.ToString();
                mensaje.Status = "Error";
                return Json(mensaje, JsonRequestBehavior.AllowGet);
            }
        }
    }
    public class Mensajes
    {
        public string Status { get; set; }
        public string Mensaje { get; set; }
    }

}