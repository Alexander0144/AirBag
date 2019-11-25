using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Airbag.Datos.DTO;
using Airbag.Logica;

namespace Airbag.Admin.Controllers
{
    public class CompraController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ListadeDatosdeCompras()
        {
            LogicaCompra ologicaCompra = new LogicaCompra();

            List<CompraDTO> listardatosCompras = ologicaCompra.ObtenerDatosCompras();

            return Json(new { listardatosCompras });
        }

        //[HttpPost]
        //public JsonResult VisualizarDetallesdeCompras()
        //{

        //}


    }
}