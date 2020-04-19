using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL
{
    internal class ConnectionSQLServer:IDisposable
    {

        String _connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection connection = null;


        public ConnectionSQLServer()
        {
            connection = new SqlConnection(_connStr);
            connection.Open();
        }


        public int ExcueteQuery(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            int res = command.ExecuteNonQuery();
            return res;
        }


        public Object ExcueteScalar(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            return command.ExecuteScalar();
        }

        public SqlDataReader ExcueteReader(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
