using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Airbag.Usuario.Models;

namespace Airbag.Usuario.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult VistaDetallesProducto()
        {
            return View();
        }

        public ActionResult VistaProductosEnCategoria(string Categoria)
        {
            ProductosEnCategoriaViewModel modeloVistaProductosEnCategoria = new ProductosEnCategoriaViewModel();
            modeloVistaProductosEnCategoria.nombreCategoria = Categoria;
            return View(modeloVistaProductosEnCategoria);
        }
    }
}