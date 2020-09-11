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

        public Aeropuerto[] FindByNombre(string nombre)
        {
            string sql = "SELECT * FROM aeropuerto WHERE borrado = 'N' AND nombre LIKE '%" + nombre + "%'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = Mapper(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }

        public Aeropuerto[] FindByNombreOrdenado(string nombre)
        {
            string sql = "SELECT * FROM aeropuerto WHERE borrado = 'N' AND nombre LIKE '%" + nombre + "%' ORDER BY nombre";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = Mapper(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }


        public bool delete(int id)
        {
            // Es borrado logico
            string sql = "UPDATE aeropuerto SET borrado = 'S' WHERE id = " + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;
        }

        public bool add(Aeropuerto aeropuerto)
        {
            string sql = "INSERT INTO aeropuerto (nombre, idCiudad, borrado) VALUES ('" + aeropuerto.Nombre + "', " +  aeropuerto.IdCiudad + ", 'N')";

            return DBHelper.getDBHelper().ejecutarSQL(sql) > 0;
        }

        public bool modify(int id, string nombre, int idCiudad)
        {
            string sql = "UPDATE aeropuerto SET nombre = '" + nombre + "', idCiudad = " + idCiudad + " WHERE id = " + id+ " and borrado = 'N'";

            return DBHelper.getDBHelper().ejecutarSQL(sql) > 0;
        }

        public Aeropuerto[] ObtenerTodo()
        {
            string sql = "SELECT * FROM aeropuerto WHERE borrado = 'N' ";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = Mapper(AeroDT.Rows[i]);
            }
            return aeropuertos;

        }

        public Aeropuerto[] ObtenerTodoOrdenado()
        {
            string sql = "SELECT * FROM aeropuerto WHERE borrado = 'N' ORDER BY nombre";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = Mapper(AeroDT.Rows[i]);
            }
            return aeropuertos;

        }

        public IList<Aeropuerto> getAll()
        {
            // Falta implementar, en realidad esta mas arriba pero de otra forma
            throw new NotImplementedException();
        }

        bool IDao<Aeropuerto>.delete(string id)
        {
            //Falta implementar pero esta arriba de otra forma
            throw new NotImplementedException();
        }
    }
}

