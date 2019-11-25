using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Airbag.Datos;
using Airbag.Usuario.Models;
using Airbag.Logica;

namespace Airbag.Usuario.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult InicioSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InicarSesion(string correo, string contraseña)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            string mensaje = logicaUsuario.VerificarUsuario(correo, contraseña);
            return Json(new { mensaje = mensaje});
        }

        public ActionResult CrearCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarUsuario(tblUsuario usuario)
        {
            string mensaje = "correcto";
            bool pudoInsertar = false;
            usuario.cContrasenia = LogicaUsuario.EncriptarContraseñaUsuario(usuario.cContrasenia);
            CrearCuentaViewModel crearCuentaViewModel = new CrearCuentaViewModel();
            if (LogicaUsuario.ExisteCorreo(usuario.cCorreo))
            {
                mensaje = "Ya existe un usuario registrado con el correo proporcionado";
            }
            else
            {
                pudoInsertar = crearCuentaViewModel.AgregarUsuario(usuario);
            }
            return Json(new { estatus = pudoInsertar, message = mensaje});
        }

        //Posiblemente innecesario
        [HttpPost]
        public ActionResult CerrarSesion()
        {
            LogicaUsuario.CerrarSesion();
            return Json(new { mensaje = "success"});
        }
    }
}