using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Implementacion;
using CordobaVuela.Negocio.Entidades;
namespace CordobaVuela.Negocio.Servicios
{
    class AeropuertoService
    {
        private AeropuertoDaoSqlImp dao;

        public AeropuertoService()
        {
            dao = new AeropuertoDaoSqlImp();
        }

        public bool CrearAeropuerto(Aeropuerto a) 
        {
            return dao.add(a);
        }
    
        public Aeropuerto[] FindByNombre(string nombre)
        {
            return dao.FindByNombre(nombre);
        }

        public Aeropuerto[] getAll()
        {
            return dao.ObtenerTodo();
        }

        public Aeropuerto[] FindByNombreOrdenado(string nombre)
        {
            return dao.FindByNombreOrdenado(nombre);
        }

        public Aeropuerto[] getAllOrdenado()
        {
            return dao.ObtenerTodoOrdenado();
        }


    }
}
