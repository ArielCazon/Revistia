using RevistiaTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevistiaTP.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string busqueda = "")
        {
            try
            {
                HomeModel model = new HomeModel(CargarUsuario());
                model.Usuario = CargarUsuario();
                model.Busqueda = busqueda;
                ViewBag.busqueda = busqueda;

                return View(model);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(new Exception("Ha ocurrido un error inesperado." + ex), "Home", "Index"));
            }
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