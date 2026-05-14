using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class HomeController : Controller
    {
        // METODO PARA RETORNAR JSONS
        //public ActionResult Index()
        //{
        //    var alumno1 = new Persona() { Nombre = "Uriel", Edad = 20, Empleado = true };
        //    var alumno2 = new Persona() { Nombre = "Bryan", Edad = 21, Empleado = false };
        //    return Json(new List<Persona>() { alumno1, alumno2}, JsonRequestBehavior.AllowGet);

        //}

        /*public ViewResult Index()
        {
            // return Content("Uriel Hernandez ASP.NET");
            return View();
        }
        */

        // PARA HACER REDIRECCIONAMIENTO A OTRA PAGINA
        //public RedirectResult Index()
        //{
        //    return Redirect("https://www.google.com.mx");
        //}

        public RedirectToRouteResult Index()
        {
            return RedirectToAction("Index", "Pruebas");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}