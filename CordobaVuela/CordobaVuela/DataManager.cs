using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela
{
    class DataManager
    {

        private SqlConnection dbConnection;

        private static DataManager instance;

        public DataManager()
        {
            dbConnection = new SqlConnection();
            var string_conection = "Data Source=BENJAMIN\\SQLEXPRESS;Initial Catalog=CordobaVuela;Integrated Security=true;";
            dbConnection.ConnectionString = string_conection;

        }
        
        public static DataManager GetInstance()
        {
            if (instance == null)
            { instance = new DataManager();}

            instance.Open();
           
            return instance;

        }

        private void Open()
        {
            if (dbConnection.State != ConnectionState.Open)
            {
                dbConnection.Open();
            }
        }


        private void Close()
        {
            if (dbConnection.State != ConnectionState.Closed)
            {
                dbConnection.Close();
            }
        }


        // Permite hacer una consulta de tipo SELECT y devuelve un DataTable
        public DataTable ConsultaSQL(string strSql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                //Agregamos los filtros recibidos como parametros
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        // Permite realizar una consulta de tipo INSERT, UPDATE O DELETE  y devuelve un entero con la cantidad de filas afectadas.
        public int EjecutarSQL(string strSql, Dictionary<string, object> prs = null)
        {

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

          
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                // Retorna el resultado de ejecutar la sentencia
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }



       
        // Se utiliza para sentencias SQL del tipo SELECT. Recibe por valor una sentencia sql como string y devuelve un valor entero
       
        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }
    }
}
