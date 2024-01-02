using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace InventoryManagementSystem
{
   public static class DataBaseAccess
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSHARP_PROJECT\InventoryManagementSystemsln\InventoryManagementDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public static DataTable getData(string query, out string error)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                //command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet set = new DataSet();
                adapter.Fill(set);
                DataTable dt = set.Tables[0];

                connection.Close();
                error = "";
                return dt;

            }
            catch (Exception e)
            {
                error = e.Message;

                return null;
            }
        }
        public static void InsertData(string query,out string error)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                error ="";
                

            }
            catch(Exception e)
            {
                error = e.Message;
            }
        }
    }
}
