using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    public class DatosUsuario
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblUsuario> ObtenerDatosUsuarios()
        {
            var listaUsuario = contexto.tblUsuario.ToList();
            return listaUsuario;
        }

        public bool AgregarUsuario(tblUsuario usuario)
        {
            try
            {
                //Implementar método para registrar un nuevo usuario en la base de datos
                contexto.tblUsuario.Add(usuario);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                //Modificacion a futuro
                //En lugar de retornar bool, retornar el mensaje
                Console.WriteLine(x.Message);
                return false;
            }
        }

        public bool ExisteCorreoEnBDD(string cCorreo)
        {
            return contexto.tblUsuario.Any(u => u.cCorreo == cCorreo);
        }

    }
}
