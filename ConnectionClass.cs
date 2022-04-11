using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnections
{
    public class ConnectionClass
    {
        public static void ConnectToSQLDB()
        {
            string server = @"AYOTOLAJINAC65A\SQLEXPRESS";
            string username = "";
            string password = "";
            string database = "CSharpTraning";

            string connString = @"Data Source = " + server + "; Initial Catalog = " + database + "; Persist Security Info=True; Integrated Security =True";

            SqlConnection connection = new SqlConnection(connString);

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("Insert into Student(uniqueRef, phoneNo, StudentName)values ('kjiuytjk', '07069009776', 'Yewande Akinjewe')", connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Command Executed");
                }
                    Console.WriteLine("DB is now opened");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
