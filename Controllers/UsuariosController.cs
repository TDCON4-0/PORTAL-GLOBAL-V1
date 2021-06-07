using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portal_Global.Controllers;
using Portal_Global.Models;
using Portal_Global.Models.ViewModels;

namespace Portal_Global.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: TablaUsuarios
 




        [HttpGet]
        public ViewResult EditarUsuario(string tag)
        {
            try
            {
                ViewBag.IDUsuario = tag;
                return View("EditarUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ViewResult EliminarUsuario(string Id, string Status)
        {
            try
            {
                ViewBag.IDUsuario = Id;
                ViewBag.Status = Status;
                return View("EliminarUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




      


        [HttpGet]
        public ViewResult ProfileUser()
        {
            try
            {
                return View("../Usuarios/ProfileUser");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet]
        public ViewResult AllUsuarios()
        {
            try
            {
                return View("../Usuarios/AllUsuarios");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [HttpGet]
        public ViewResult NewUsuario()
        {
            try
            {
                return View("../Usuarios/NuevoUsuario");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ViewResult NewPerfil()
        {
            try
            {
                return View("../Usuarios/NuevoPerfil");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
 }