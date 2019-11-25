namespace Airbag.Datos.DTO
{
    /// <summary>
    ///  Esta clase DTO es la responsable obtener los campos necesarios a utilizar de la tabla Usuarios.
    /// </summary>
    public class UsuarioDTO
    {
        /// <summary>
        /// Identificador del usuario.
        /// </summary>
        public int iIdUsuario{ get; set; }
        /// <summary>
        /// Estatus del usuario.
        /// </summary>
        public int iEstatus { get; set; }
        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string cNombre { get; set; }
        /// <summary>
        /// Apellido Paterno del usuario.
        /// </summary>
        public string cApellidoPaterno { get; set; }
        /// <summary>
        /// Apellido Materno del usuario.
        /// </summary>
        public string cApellidoMaterno { get; set; }
        /// <summary>
        /// Correo electrónico del usuario.
        /// </summary>
        public string cCorreo { get; set; }

    }
}
