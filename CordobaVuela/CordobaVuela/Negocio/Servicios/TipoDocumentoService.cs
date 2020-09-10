using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Implementacion;
using CordobaVuela.Negocio.Entidades;

namespace CordobaVuela.Negocio.Servicios
{
    public class TipoDocumentoService
    {
        private TipoDocumentoDao dao;

        public TipoDocumentoService()
        {
            dao = new TipoDocumentoDao();
        }

        public TipoDocumento[] ListadoDeTipoDocumento()
        {
            return dao.getTipoDocumento();
        }

    }
}
