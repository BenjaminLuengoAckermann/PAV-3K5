using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Interfaz;
using CordobaVuela.Negocio.Entidades;
using CordobaVuela.Datos.Helper;

namespace CordobaVuela.Datos.Dao.Implementacion
{
    public class UsuarioDaoSqlImp : IDao<Usuario>
    {
        //Vamos a reutilizar este método para crear cada objeto Usu:
        public Usuario findById(string id)
        {
            string sql = "SELECT * FROM usuario u WHERE u.idUsuario = " + id;
            DataTable UsuarioDT = DBHelper.getDBHelper().ConsultaSQL(sql);
            
            if (UsuarioDT != null)
            {
                 return Mapper(UsuarioDT.Rows[0]);
            }
            return null;
        }

        private Usuario Mapper(DataRow usuarioRow)
        {
            Usuario usu = new Usuario();
            
           
            usu.IdUsuario = usuarioRow["idUsuario"].ToString();
            usu.Password = usuarioRow["password"].ToString();
      
            return usu;
        }

        public bool delete(string id)
        {           
            string sql = "DELETE FROM usuario WHERE id = " + id;
            return DBHelper.getDBHelper().ejecutarSQL(sql) != 0;
        }

        public bool add(Usuario usu)
        {
            string sql = "INSERT INTO usuario (idUsuario, password) VALUES ("+ usu.IdUsuario+ ", "+ usu.Password+")" ;
           
            return DBHelper.getDBHelper().ejecutarSQL(sql) > 0;
        }

        public IList<Usuario> getAll()
        {
            //falta completar implemtación
            return null;
        }

        public bool FindByName(Usuario u)
        {
            string sql = "SELECT * FROM usuario u WHERE u.idUsuario LIKE '" +u.IdUsuario +"' AND u.password LIKE '" + u.Password + "'";
            DataTable UsuarioDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            if (UsuarioDT.Rows.Count == 1)
            {
              return true;
            }
            return false;
        }

        public bool PermisoUser(Usuario u)
        {
            string sql = "SELECT * FROM empleado e INNER JOIN usuario u ON (u.idUsuario = e.idUsuario) WHERE u.idUsuario LIKE '"  + u.IdUsuario + "'";
            DataTable UsuarioDT = DBHelper.getDBHelper().ConsultaSQL(sql);

            if (UsuarioDT.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

    }
}
