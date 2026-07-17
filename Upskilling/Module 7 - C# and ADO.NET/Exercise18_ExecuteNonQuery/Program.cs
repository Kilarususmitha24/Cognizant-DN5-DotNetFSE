using System;
using System.Data.SqlClient;

namespace ExecuteNonQueryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
            "Server=localhost;Database=CommunityEventDB;Trusted_Connection=True;TrustServerCertificate=True;";

            SqlConnection connection =
                new SqlConnection(connectionString);

            try
            {
                connection.Open();

                Console.WriteLine("Connection Opened Successfully.");

                string insertQuery =
                "INSERT INTO Students VALUES (103,'Anjali','IT',95)";

                SqlCommand insertCommand =
                    new SqlCommand(insertQuery, connection);

                int insertRows =
                    insertCommand.ExecuteNonQuery();

                Console.WriteLine();

                Console.WriteLine(insertRows +
                    " Record Inserted Successfully.");

                string updateQuery =
                "UPDATE Students SET Marks=98 WHERE Id=103";

                SqlCommand updateCommand =
                    new SqlCommand(updateQuery, connection);

                int updateRows =
                    updateCommand.ExecuteNonQuery();

                Console.WriteLine(updateRows +
                    " Record Updated Successfully.");

                string deleteQuery =
                "DELETE FROM Students WHERE Id=102";

                SqlCommand deleteCommand =
                    new SqlCommand(deleteQuery, connection);

                int deleteRows =
                    deleteCommand.ExecuteNonQuery();

                Console.WriteLine(deleteRows +
                    " Record Deleted Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();

                Console.WriteLine();

                Console.WriteLine("Connection Closed.");
            }

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
