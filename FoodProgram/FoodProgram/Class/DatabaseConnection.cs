using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProgram
{
    public class DatabaseConnection
    {

        static private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString;
        static public SqlConnection con = new SqlConnection(connectionString);


        public void OpenDbCon()
        {
            con.Open();
        }

        public void CloseDbCon()
        {
            con.Close();
        }

    }
}
