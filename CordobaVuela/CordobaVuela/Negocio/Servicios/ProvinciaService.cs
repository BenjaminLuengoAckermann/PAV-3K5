using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Implementacion;
using CordobaVuela.Negocio.Entidades;

namespace CordobaVuela.Negocio.Servicios
{
    public class ProvinciaService
    {


        private ProvinciaDaoSqlImp dao;

        public ProvinciaService()
        {
            dao = new ProvinciaDaoSqlImp();
        }


        public Provincia[] ListadoDeProvincias()
        {
            return dao.getProvincias();
        }

        public Provincia[] ListadoDeProvinciasPorPais(string pais)
        {
            return dao.getProvinciasPorPais(pais);
        }
    }
}
