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
    public class ProvinciaDaoSqlImp //: IDao<Provincia>
    {
        //Vamos a reutilizar este método para crear cada objeto Pais:
        public Provincia findById(string id)
        {
            string sql = "SELECT * FROM provincia p WHERE p.id = " + id;
            DataTable ProvDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            if (ProvDT != null)
            {
                return Mapper(ProvDT.Rows[0]);
            }
            return null;
        }

        private Provincia Mapper(DataRow pciaRow)
        {
            Provincia pcia = new Provincia();


            pcia.IdProvincia = (int)pciaRow["id"];
            pcia.Nombre = pciaRow["nombre"].ToString();

            return pcia;
        }

        public bool delete(int id)
        {
            string sql = "DELETE FROM provincia WHERE id = " + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;
        }

        public bool add(Provincia pcia)
        {
            string sql = "INSERT INTO provincia (id, nombre) VALUES (" + pcia.IdProvincia + ", '" + pcia.Nombre + "')";

            return DBHelper.getDBHelper().ejecutarSQL(sql) > 0;
        }

        public IList<Pais> getAll()
        {
            //falta completar implemtación

            return null;
        }

        public string[] Provincia()
        {

            string sql = "SELECT nombre FROM provincia";
            DataTable PciaDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            string[] pcia = new string[PciaDT.Rows.Count];
            for (int i = 0; i < PciaDT.Rows.Count; i++)
            {
                pcia[i] = PciaDT.Rows[i]["nombre"].ToString();
            }
            return pcia;

        }

        public Provincia[] getProvincias()
        {
            string sql = "SELECT * FROM provincia";
            DataTable PciaDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Provincia[] pcia = new Provincia[PciaDT.Rows.Count];
            for (int i = 0; i < PciaDT.Rows.Count; i++)
            {
                pcia[i] = Mapper(PciaDT.Rows[i]);
            }
            return pcia;
        }

        //Este metodo es una prueba para que cuando se elija un pais en el combo muestre solo las provincias de ese pais
        public Provincia[] getProvinciasPorPais(string pais)
        {
            string sql = "SELECT * FROM provincia p INNER JOIN pais pa ON (p.idPais = pa.id) WHERE pa.nombre LIKE '" + pais + "'";
            DataTable PciaDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Provincia[] pcia = new Provincia[PciaDT.Rows.Count];
            for (int i = 0; i < PciaDT.Rows.Count; i++)
            {
                pcia[i] = Mapper(PciaDT.Rows[i]);
            }
            return pcia;
        }

    }
}
