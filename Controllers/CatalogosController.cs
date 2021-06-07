using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal_Global.Controllers
{
    public class CatalogosController : Controller
    {
        // GET: Catalogos
        public ActionResult AddSistema()
        {
            return View();
        }


        public ActionResult AllSystems()
        {
            return View();
        }


        [HttpGet]
        public ViewResult EditSystem(string ID,string SistemaName, string IdBuilding,string Building,string Status)
        {
            try
            {
                ViewBag.ID = ID;
                ViewBag.SistemaName = SistemaName;
                ViewBag.IdBuilding = IdBuilding;
                ViewBag.Building = Building;
                ViewBag.Status = Status;
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
        //modulos

        public ActionResult AllModules()
        {
            return View();
        }


        public ActionResult EditModule(string ID)
        {
            try
            {
                ViewBag.ID = ID;
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult AddModule()
        {
            return View();
        }


        //Edificios

        public ActionResult AllEdificios()
        {
            return View();
        }


        public ActionResult EditEdificios(string ID)
        {
            try
            {
                ViewBag.ID = ID;
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult AddEdificios()
        {
            return View();
        }


        //companiassssssssssssssssssssssssssssssssssssssss
        public ActionResult AllCompanias()
        {
            return View();
        }


        public ActionResult EditCompanias(string ID)
        {
            try
            {
                ViewBag.ID = ID;
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult AddCompanias()
        {
            return View();
        }



        //Areassssssssssssssssssssssssssssssssssssss
        public ActionResult AllAreas()
        {
            return View();
        }


        public ActionResult EditAreas(string ID)
        {
            try
            {
                ViewBag.ID = ID;
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult AddAreas()
        {
            return View();
        }









        //dEPARTMENTS DEPARTMENSTSSSSS
        public ActionResult AllDepartments()
        {
            return View();
        }


        public ActionResult EditDepartments(string ID)
        {
            try
            {
                ViewBag.ID = ID;
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult AddDepartments()
        {
            return View();
        }




    }





}