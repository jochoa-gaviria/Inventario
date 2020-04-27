using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventario.Web.Data
{
    public class Connection
    {

        public static SqlConnection OpenConnect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=dev1.imsoluciones.net;" +
            "Initial Catalog=DBTEST;" +
            "User id=TestPractica;" +
            "Password=IntelMovil135;";
            conn.Open();
            return conn;
        }
        


        public static void CloseConnect(SqlConnection conn)
        {
            conn.Close();
        }
    }
}
