using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Implementacion;
using CordobaVuela.Negocio.Entidades;

namespace CordobaVuela.Negocio.Servicios
{
    public class CiudadService
    {
        private CiudadDaoSqlImp dao;

        public CiudadService()
        {
            dao = new CiudadDaoSqlImp();
        }


        public Ciudad[] ListadoDeciudades()
        {
            return dao.getCiudades();
        }

        public Ciudad ObtenerCiudad(string nom)
        {
            return dao.findByNombre(nom);
        }


        

        public Ciudad[] ListadoDeCiudadesPorProvincia(string pcia)
        {
            return dao.getCiudadesPorProvincia(pcia);
        }
    
    
        public Ciudad FindById(int id)
        {
            return dao.findById(id);
        }
    }
}


