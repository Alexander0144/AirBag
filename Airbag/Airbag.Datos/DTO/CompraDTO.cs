using System;

namespace Airbag.Datos.DTO
{
    public class CompraDTO
    {
        /// <summary>
        /// Identificador de la compra realizada.
        /// </summary>
        public int iIdCompra { get; set; }

        /// <summary>
        /// Identificador del usuario.
        /// </summary>
        public int iIdUsuario { get; set; }

        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string cNombre { get; set; }

        /// <summary>
        /// Apellido Paterno del usuario.
        /// </summary>
        public string cApellidoPaterno { get; set; }

        /// <summary>
        /// Apellido Materno del usuario,
        /// </summary>
        public string cApellidoMaterno { get; set; }

        /// <summary>
        /// Fecha de la compra realizada.
        /// </summary>
        public DateTime dtFechaCompra { get; set; }

    }
}
