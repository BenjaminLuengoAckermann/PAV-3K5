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
       
        private Aeropuerto MapperTresBis(DataRow aeropuertoRow)
        {
            Aeropuerto aeropuerto = new Aeropuerto();


            aeropuerto.Ciudad = aeropuertoRow["ciudad"].ToString();
            aeropuerto.Nombre = aeropuertoRow["nombre"].ToString();
            aeropuerto.Provincia = aeropuertoRow["provincia"].ToString();
            aeropuerto.Pais = aeropuertoRow["pais"].ToString();
            aeropuerto.IdAeropuerto = (int)aeropuertoRow["idAeropuerto"];

            return aeropuerto;
        }

        public Aeropuerto[] FindByNombre(string nombre)
        {
            string sql = "SELECT A.nombre, A.id AS 'IdAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N' AND A.nombre LIKE '%" + nombre + "%'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }
        public Aeropuerto[] FindByPais(string pais)
        {
            

            string sql = "SELECT A.nombre, A.id AS 'idAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N' AND P.nombre LIKE '" + pais + "'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }
        public Aeropuerto[] FindByProvincia(string provincia)
        {
            string sql = "SELECT A.nombre, A.id AS 'IdAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N' AND PR.nombre LIKE '" + provincia + "'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }
        public Aeropuerto[] FindByCiudad(string ciudad)
        {
            string sql = "SELECT A.nombre, A.id AS 'IdAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N' AND C.nombre LIKE '" + ciudad + "'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }

        public Aeropuerto[] FindByPaisYNombre(string pais, string nombre)
        {

            string sql = "SELECT A.nombre, A.id AS 'IdAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N' AND P.nombre LIKE '" + pais + "' AND A.nombre LIKE '%" + nombre + "%'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }
        public Aeropuerto[] FindByProvinciaYNombre(string provincia, string nombre)
        {

            string sql = "SELECT A.nombre, A.id AS 'IdAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N' AND PR.nombre LIKE '" + provincia + "' AND A.nombre LIKE '%" + nombre + "%'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }
        public Aeropuerto[] FindByCiudadYNombre(string ciudad, string nombre)
        {

            string sql = "SELECT A.nombre, A.id AS 'IdAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N' AND C.nombre LIKE '" + ciudad + "' AND A.nombre LIKE '%" + nombre + "%'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
            }
            return aeropuertos;
        }



        public Aeropuerto[] FindAll()
        {
            string sql = "SELECT A.nombre, A.id AS 'IdAeropuerto', C.nombre AS 'ciudad', PR.nombre AS 'provincia', P.nombre AS 'pais' FROM aeropuerto A JOIN ciudad C on C.id = A.idCiudad JOIN provincia PR ON PR.id = C.idProvincia JOIN pais P ON P.id = PR.idPais WHERE A.borrado = 'N'";
            DataTable AeroDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Aeropuerto[] aeropuertos = new Aeropuerto[AeroDT.Rows.Count];
            for (int i = 0; i < AeroDT.Rows.Count; i++)
            {
                aeropuertos[i] = MapperTresBis(AeroDT.Rows[i]);
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

