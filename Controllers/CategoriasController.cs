using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ProductoCategoria.Models;
using System.Web.Mvc;
using System.Web;


namespace ProductoCategoria.Controllers
{
    public class CategoriasController: Controller
    {
        Models.Categorias contexto = new Models.Categorias();
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

    }
}