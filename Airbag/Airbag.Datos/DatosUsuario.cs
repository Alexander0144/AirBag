using System.Collections.Generic;
using System.Linq;

namespace Airbag.Datos

{
    public class DatosUsuario
    {
        AirbagEntities contexto = new AirbagEntities();

        public bool AgregarUsuario(tblUsuario Usuario)
        {

            //AirbagEntities entities = new AirbagEntities();
            try
            {
                contexto.tblUsuario.Add(Usuario);
                contexto.SaveChanges();
                return true;
            }catch(System.Exception e)
            {
                return false;
            }
        }

        public List<tblUsuario> ObtenerDatosUsuarios()
        {
            //AirbagEntities contexto = new AirbagEntities();
            return contexto.tblUsuario.ToList();
        }

        public bool ExisteCorreoEnBDD(string cCorreo)
        {
            //AirbagEntities contexto = new AirbagEntities();
            return contexto.tblUsuario.Any(u => u.cCorreo == cCorreo);
        }


    }
}
