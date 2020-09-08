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
   public class PaisDaoSqlImp : IDao<Pais>
    {

        //Vamos a reutilizar este método para crear cada objeto Pais:
        public Pais findById(string id)
        {
            string sql = "SELECT * FROM pais p WHERE p.id = " + id;
            DataTable PaisDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            if (PaisDT != null)
            {
                return Mapper(PaisDT.Rows[0]);
            }
            return null;
        }

        private Pais Mapper(DataRow paisRow)
        {
            Pais pais = new Pais();


            pais.IdPais = (int)paisRow["id"];
            pais.Nombre = paisRow["nombre"].ToString();

            return pais;
        }

        public bool delete(string id)
        {
            string sql = "DELETE FROM pais WHERE id = " + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;
        }

        public bool add(Pais pais)
        {
            string sql = "INSERT INTO pais (id, ) VALUES (" + pais.IdPais + ", " + pais.Nombre + ")";

            return DBHelper.getDBHelper().ejecutarSQL(sql) > 0;
        }

        public IList<Pais> getAll()
        {
            //falta completar implemtación
            
            return null;
        }

        public string[] Paises()        
        {
            
            string sql = "SELECT nombre FROM pais";
            DataTable PaisDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            
            string[] paises = new string[PaisDT.Rows.Count];
            for (int i = 0; i < PaisDT.Rows.Count; i++)
            {
                paises[i] = PaisDT.Rows[i]["nombre"].ToString();
            }
            return paises;

        }

        public Pais[] getPaises()
        {
            string sql = "SELECT * FROM pais";
            DataTable PaisDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            Pais[] paises = new Pais[PaisDT.Rows.Count];
            for (int i = 0; i < PaisDT.Rows.Count; i++)
            {
                paises[i] = Mapper(PaisDT.Rows[i]);
            }
            return paises;
        }


    }
}
