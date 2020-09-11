using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Implementacion;
using CordobaVuela.Negocio.Entidades;

namespace CordobaVuela.Negocio.Servicios
{
    public class PaisService
    {
        private PaisDaoSqlImp dao;

        public PaisService()
        {
            dao = new PaisDaoSqlImp();
        }


        public Pais[] ListadoDePaises() 
        {
            return dao.getPaises();
        }


        /*public Pais FindById(int id)
        {
            return dao.findById2(id);
        }
        */
    }


}
