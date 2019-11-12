using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    class DatosDireccion
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblDireccion> ObtenerDatosDirecciones()
        {
            //implementar método que retorne lista con datos de la dirección de cada usuario registrado
            return null;
        }

        public void AgregarDireccion(tblDireccion direccion)
        {
            //implementar método para agregar una nieva dirección a la BDD
        }
    }
}
