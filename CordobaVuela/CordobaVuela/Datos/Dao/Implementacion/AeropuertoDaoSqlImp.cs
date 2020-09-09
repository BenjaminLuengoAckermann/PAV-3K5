using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Interfaz;
using CordobaVuela.Negocio.Entidades;
using CordobaVuela.Datos.Helper;
using System.Data;

namespace CordobaVuela.Datos.Dao.Implementacion
{
    class AeropuertoDaoSqlImp : IDao<Aeropuerto>
    {
     
        //FALTAN IMPLEMENTAR ALGUNOS METODOS
        public Aeropuerto findById(string id)
        {
           
           return null;

        }
        private Aeropuerto Mapper(DataRow aeropuertoRow)
        {
            Aeropuerto aeropuerto = new Aeropuerto();


            aeropuerto.IdCiudad = (int)aeropuertoRow["idCiudad"];
            aeropuerto.Nombre = aeropuertoRow["nombre"].ToString();
            aeropuerto.IdAeropuerto = (int)aeropuertoRow["id"];

            return aeropuerto;
        }

        public bool delete(string id)
        {
            string sql = "DELETE FROM aeropuerto WHERE id = " + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;
        }

        public bool add(Aeropuerto aeropuerto)
        {
            string sql = "INSERT INTO aeropuerto (nombre, idCiudad) VALUES ('" + aeropuerto.Nombre + "', " +  aeropuerto.IdCiudad + ")";

            return DBHelper.getDBHelper().ejecutarSQL(sql) > 0;
        }

        public IList<Aeropuerto> getAll()
        {
            //falta completar implemtación
            return null;
        }

    }
}

