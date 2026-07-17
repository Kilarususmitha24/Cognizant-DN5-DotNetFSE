using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
            "Server=localhost;Database=CommunityEventDB;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Connection Opened Successfully.\n");

                    string query = "SELECT * FROM Students";

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    Console.WriteLine("===== Student Details =====\n");

                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine("ID         : " + row["Id"]);
                        Console.WriteLine("Name       : " + row["Name"]);
                        Console.WriteLine("Department : " + row["Department"]);
                        Console.WriteLine("Marks      : " + row["Marks"]);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Total Records : " + table.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
