using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904ASP.Models;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    {
        public ActionResult Index(Cine c)
        {
            if (c.CantidadBoletos > 0)
            {
                c.CalcularTotal();
            }

            return View(c);
        }
    }
}