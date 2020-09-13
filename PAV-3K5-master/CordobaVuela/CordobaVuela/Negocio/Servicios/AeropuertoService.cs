﻿using System;
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

        public Aeropuerto[] getAll()
        {
            return dao.ObtenerTodo();
        }
        public Aeropuerto[] FindAll()
        {
            return dao.FindAll();
        }


        public Aeropuerto[] FindByNombreOrdenado(string nombre)
        {
            return dao.FindByNombreOrdenado(nombre);
        }

        public Aeropuerto[] getAllOrdenado()
        {
            return dao.ObtenerTodoOrdenado();
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
        public bool BorrarAeropuerto(int id)
        {
            return dao.delete(id);
        }

    }
}
