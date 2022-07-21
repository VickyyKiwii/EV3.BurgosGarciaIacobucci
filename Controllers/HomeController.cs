using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProductoCategoria.Models;
using System.Web;

namespace ProductoCategoria.Controllers
{
    public class HomeController : Controller
    {
            private ProductoCategoria.Models.servicioEntities1 contextoDatos = new Models.servicioEntities1();

        public ActionResult Index()
        {
            //cargamos los productos como una lista y lo pasamos a la vista
            var productos = contextoDatos.Producto.ToList();

            return View(productos);
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

        public ActionResult Detalle(int id)
        {

            var prod = (from p in contextoDatos.Producto where p.id == id select p).FirstOrDefault();

            if (prod != null)
                return View(prod);
            else
                return RedirectToAction("Index");
        }

    }
}