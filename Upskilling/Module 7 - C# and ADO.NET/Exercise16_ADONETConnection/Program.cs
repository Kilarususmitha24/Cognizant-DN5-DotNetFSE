using System;
using System.Data.SqlClient;

namespace ADONETConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Server=localhost;Database=CommunityEventDB;Trusted_Connection=True;TrustServerCertificate=True;";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                Console.WriteLine("Opening SQL Server Connection...");

                connection.Open();

                Console.WriteLine("Connection Opened Successfully.");

                Console.WriteLine("Database Name : " + connection.Database);

                Console.WriteLine("Data Source : " + connection.DataSource);

                Console.WriteLine("Server Version : " + connection.ServerVersion);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Failed!");

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();

                    Console.WriteLine();

                    Console.WriteLine("Connection Closed Successfully.");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
