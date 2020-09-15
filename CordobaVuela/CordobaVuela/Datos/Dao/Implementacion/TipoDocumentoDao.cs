using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Helper;
using CordobaVuela.Negocio.Entidades;

namespace CordobaVuela.Datos.Dao.Implementacion
{
    public class TipoDocumentoDao
    {
        // Solo implementaremos los metodos para acceder a la BD ya que no se podran realizar inserts de esta entidad

            public TipoDocumento FindById(int id)
            {
                string sql = "SELECT * FROM tipoDocumento t WHERE t.id = " + id;
                DataTable TipoDT = DBHelper.getDBHelper().ConsultaSQL(sql);

                if (TipoDT != null)
                {
                    return Mapper(TipoDT.Rows[0]);
                }
                return null;
            }


            private TipoDocumento Mapper(DataRow tipoDocRow)
        {
            TipoDocumento tipoDoc = new TipoDocumento();


            tipoDoc.Id = (int)tipoDocRow["id"];
            tipoDoc.Nombre = tipoDocRow["nombre"].ToString();
            tipoDoc.IdPais = (int)tipoDocRow["idPais"];
            


            return tipoDoc;
        }

        public string[] TipoDocumento()
        {

            string sql = "SELECT nombre FROM tipoDocumento";
            DataTable TipoDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            string[] tipoDoc = new string[TipoDT.Rows.Count];
            for (int i = 0; i < TipoDT.Rows.Count; i++)
            {
                tipoDoc[i] = TipoDT.Rows[i]["nombre"].ToString();
            }
            return tipoDoc;

        }

        public TipoDocumento[] getTipoDocumento()
        {
            string sql = "SELECT * FROM tipoDocumento";
            DataTable TipoDocDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            TipoDocumento[] tipoDoc = new TipoDocumento[TipoDocDT.Rows.Count];
            for (int i = 0; i < TipoDocDT.Rows.Count; i++)
            {
                tipoDoc[i] = Mapper(TipoDocDT.Rows[i]);
            }
            return tipoDoc;
        }



    }
}
