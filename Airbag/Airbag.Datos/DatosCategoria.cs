using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbag.Datos

{
    class DatosCategoria
    {
        AirbagEntities contexto = new AirbagEntities();
        public List<tblCat_Categoria> ObtenerDatosCategorias()
        {
            //implementar metodo que retorne lista con datos de las categorías Registradas
            return null;
        }

        public void AgregarCategoria(tblCat_Categoria categoria)
        {
            //implementar metodo para registrar una nueva categoria en la bdd
        }
    }
}
