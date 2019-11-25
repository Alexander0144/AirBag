using Airbag.Datos;
using Airbag.Datos.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Airbag.Logica
{
    public class LogicaCompra
    {
        public List<CompraDTO> ObtenerDatosCompras()
        {
            AirbagEntities contexto = new AirbagEntities();

            contexto.Configuration.LazyLoadingEnabled = false;
            contexto.Configuration.ProxyCreationEnabled = false;

            List<CompraDTO> lstCompras = (from c in contexto.tblCompra
                                           join u in contexto.tblUsuario on c.iIdCompra equals u.iIdUsuario
                                           select new CompraDTO
                                           {
                                               iIdCompra = c.iIdCompra,
                                               iIdUsuario = c.iIdUsuario,
                                               cNombre = u.cNombre,
                                               cApellidoPaterno = u.cApellidoPaterno,
                                               cApellidoMaterno = u.cApellidoMaterno,
                                               dtFechaCompra = c.dtFechaCompra,

                                           }).ToList();
            return lstCompras;
        }

        
        //public DetallesCompraDTO ObtenerDetallesCompra()
        //{
        //    AirbagEntities contexto = new AirbagEntities();

        //    DetallesCompraDTO detallecompra = (from d in contexto.tblDetallesCompra)
        //}
    }
}
