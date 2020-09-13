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

        public bool ModificarAeropuerto(int id, string nombre, int ciudad)
        {
            return dao.modify(id, nombre, ciudad);
        }
        public Aeropuerto[] FindByNombre(string nombre)
        {
            return dao.FindByNombre(nombre);
        }

        
        public Aeropuerto[] FindAll()
        {
            return dao.FindAll();
        }

        
        public Aeropuerto[] FindByPais(string nombre)
        {
            return dao.FindByPais(nombre);
        }
        public Aeropuerto[] FindByProvincia(string nombre)
        {
            return dao.FindByProvincia(nombre);
        }
        public Aeropuerto[] FindByCiudad(string nombre)
        {
            return dao.FindByCiudad(nombre);
        }
        public Aeropuerto[] FindByPaisYNombre(string pais, string nombre)
        {
            return dao.FindByPaisYNombre(pais, nombre);
        }
        public Aeropuerto[] FindByProvinciaYNombre(string provincia, string nombre)
        {
            return dao.FindByProvinciaYNombre(provincia, nombre);
        }
        public Aeropuerto[] FindByCiudadYNombre(string ciudad, string nombre)
        {
            return dao.FindByCiudadYNombre(ciudad, nombre);
        }


        public bool BorrarAeropuerto(int id)
        {
            return dao.delete(id);
        }

    }
}
