using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    class DatosTarjeta
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblTarjeta> ObtenerDatosTarjetas()
        {
            //implementar método que retorne lista con datos de la forma de pago(tarjeta) de cada usuario registrado
            return null;
        }

        public void AgregarTarjeta(tblTarjeta tarjeta)
        {
            //Implementar método para agregar un nuevo registro de una tarjeta a la Base de Datos
            //A cada usuario le corresponde una sola tarjeta, se podrá modificar el registro para reemplazarlo por otra tarjeta
        }
    }
}
