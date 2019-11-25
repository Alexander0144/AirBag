using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Airbag.Datos.DTO;
using Airbag.Logica;


namespace Airbag.Admin.Controllers
{
    public class UsuarioController : Controller
    {
        string _cMensaje; // Variable para almacenar mensaje de excepción.

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Método que obtiene la lista de los datos registrados de los usuarios.
        /// </summary>
        /// <returns>Devuelve la lista de los usuarios en un objeto Json y el mensaje de excepción.</returns>
        [HttpPost]
        public JsonResult ListarUsuarios()
        {
            List<UsuarioDTO> _olistaUsuarios = new List<UsuarioDTO>();
            try
            {
                LogicaUsuario ologicaUsuario = new LogicaUsuario();
                _olistaUsuarios = ologicaUsuario.ObtenerDatosUsuarios();
            }
            catch(Exception)
            {
                _cMensaje = "Ha ocurrido un error con el servidor, No  fue posible obtener usuarios registrados";
            }
            return Json(new{ _olistaUsuarios,_cMensaje});
        }

        /// <summary>
        /// Método para cambiar el estatus del usuario.
        /// </summary>
        /// <param name="iId">Variable tipo entero que recibe el identificador del usuario</param>
        /// <param name="iEstatus">Variable tipo entero que recibe valor del estatus</param>
        /// <returns>Devuelve objetos Json con datos completos y mensaje de excepción.</returns>
        [HttpPost]
        public JsonResult CambiarEstatus(int iId, int iEstatus)
        {
            UsuarioDTO _oEstatuscambiado = new UsuarioDTO();
            try
            {
                LogicaUsuario ologicaUsuario = new LogicaUsuario();
                _oEstatuscambiado = ologicaUsuario.CambiarEstatusdeUsuario(iId, iEstatus);

                _cMensaje = "Estatus del usuario modificado correctamente";
            }
            catch (Exception)
            {
                _cMensaje = "Ha ocurrido un error al realizar su cambio.Por favor intente de nuevo ";
            }
            return Json(new { _oEstatuscambiado, _cMensaje });
        }
    }
}