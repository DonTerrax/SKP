using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProgram.Class
{
    public class CreateUserAccount
    {
        public void SendToDB(string username, string password, string email)
        {
            DatabaseConnection con = new DatabaseConnection();
            con.OpenDbCon();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            String sql = "INSERT INTO Customer(User_Name,Password,Email)\nVALUES(" +
                         username + "," + password + "," + email + "";
            command = new SqlCommand(sql, DatabaseConnection.con);
            adapter.InsertCommand = new SqlCommand(sql, DatabaseConnection.con);
            adapter.InsertCommand.ExecuteNonQuery();
            con.CloseDbCon();
        }


    }
}
