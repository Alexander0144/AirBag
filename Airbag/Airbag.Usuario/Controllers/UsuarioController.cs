using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airbag.Usuario.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult VistaPerfil()
        {
            return View();
        }

        public ActionResult VistaCarrito()
        {
            return View();
        }
    }
}