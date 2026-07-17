using System;
using System.Data.SqlClient;

namespace ExecuteReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
            "Server=localhost;Database=CommunityEventDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = "SELECT * FROM Students";

            SqlConnection connection =
                new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlCommand command =
                    new SqlCommand(query, connection);

                SqlDataReader reader =
                    command.ExecuteReader();

                Console.WriteLine("===== Student Details =====");

                while (reader.Read())
                {
                    Console.WriteLine();

                    Console.WriteLine("ID : " +
                        reader["Id"]);

                    Console.WriteLine("Name : " +
                        reader["Name"]);

                    Console.WriteLine("Department : " +
                        reader["Department"]);

                    Console.WriteLine("Marks : " +
                        reader["Marks"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
