using System;

namespace Airbag.Datos.DTO
{
    public class DetallesCompraDTO
    {
        public int iIdDetallesCompra { get; set; }

        public int iIdCompra { get; set; }

        public int iIdProducto { get; set; }

        public int iIdDireccionEnvio { get; set; }

        public int iIdUsuario { get; set; }

        public int iCantidadProducto { get; set; }

        public int iNumeroInterior { get; set; }

        public int iNumeroExterior { get; set; }

        public string cCalle { get; set; }

        public string cColonia { get; set; }

        public string cMunicipio { get; set; }

        public string cNombreUsuario { get; set; }

        public string cApellidoPaterno { get; set; }

        public string cApellidoMaterno { get; set; }

        public string cNombreProducto { get; set; }
      
        public DateTime dtFechaCompra { get; set; }

    }
}
