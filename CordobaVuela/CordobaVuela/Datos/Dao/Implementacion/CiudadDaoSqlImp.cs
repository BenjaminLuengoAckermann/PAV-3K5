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
    public class CiudadDaoSqlImp //: IDao<Ciudad>
    {
        //Vamos a reutilizar este método para crear cada objeto Pais:
        public Ciudad findById(int id)
        {
            string sql = "SELECT * from ciudad WHERE id = " + id;
            DataTable CiudadDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            if (CiudadDT != null && CiudadDT.Rows.Count > 0)
            {
                return Mapper(CiudadDT.Rows[0]);
            }
            return null;
        }

        private Ciudad Mapper(DataRow ciudadRow)
        {
            Ciudad ciudad = new Ciudad();

            ciudad.IdCiudad = (int)ciudadRow["id"];
            ciudad.Nombre = ciudadRow["nombre"].ToString();
            ciudad.Provincia = (int)ciudadRow["idProvincia"];


            return ciudad;
        }

        public bool delete(string id)
        {
            string sql = "DELETE FROM ciudad WHERE id = " + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;
        }

        public bool add(Ciudad ciudad)
        {
            string sql = "INSERT INTO ciudad (id, nombre) VALUES (" + ciudad.IdCiudad + ", '" + ciudad.Nombre + "')";

            return DBHelper.getDBHelper().ejecutarSQL(sql) > 0;
        }

        public IList<Ciudad> getAll()
        {
            //falta completar implemtación
            return null;
        }

        public string[] Ciudades()
        {

            string sql = "SELECT nombre FROM ciudad";
            DataTable CiudadDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            string[] ciudades = new string[CiudadDT.Rows.Count];
            for (int i = 0; i < CiudadDT.Rows.Count; i++)
            {
                ciudades[i] = CiudadDT.Rows[i]["nombre"].ToString();
            }
            return ciudades;


        }


        public Ciudad[] getCiudades()
        {
            string sql = "SELECT * FROM ciudad";
            DataTable CiudadDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Ciudad[] ciudades = new Ciudad[CiudadDT.Rows.Count];
            for (int i = 0; i < CiudadDT.Rows.Count; i++)
            {
                ciudades[i] = Mapper(CiudadDT.Rows[i]);
            }
            return ciudades;
        }

        public Ciudad findByNombre(string nom)
        {
            string sql = "SELECT * FROM ciudad c WHERE c.nombre = " + "'" + nom + "'";
            DataTable CiudadDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            if (CiudadDT != null)
            {
                return Mapper(CiudadDT.Rows[0]);
            }
            return null;
        }


        public string FindByIdAndReturnNombre(int id)
        {
            string sql = "SELECT * FROM ciudad c WHERE c.id = " + id;
            DataTable CiudadDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            if (CiudadDT != null)
            {
                return Mapper(CiudadDT.Rows[0]).Nombre.ToString();
            }
            return null;
        }


        public Ciudad[] getCiudadesPorProvincia(string pcia)
        {
            string sql = "SELECT * FROM ciudad c INNER JOIN provincia p ON (p.id = c.idProvincia) WHERE p.nombre LIKE '" + pcia + "'";
            DataTable CiudadDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Ciudad[] ciudad = new Ciudad[CiudadDT.Rows.Count];
            for (int i = 0; i < CiudadDT.Rows.Count; i++)
            {
                ciudad[i] = Mapper(CiudadDT.Rows[i]);
            }
            return ciudad;
        }

    }
}
