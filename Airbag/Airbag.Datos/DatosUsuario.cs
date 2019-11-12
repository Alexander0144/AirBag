using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    class DatosUsuario
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblUsuario> ObtenerDatosUsuarios()
        {
            //implementar metodo que retorne lista con datos de todos los usuarios Registrados
            return null;
        }

        public void AgregarUsuario(tblUsuario usuario)
        {
            //Implementar método para registrar un nuevo usuario en la base de datos
        }

    }
}
