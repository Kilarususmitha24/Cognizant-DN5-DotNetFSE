using System;
using System.Data;
using System.Data.SqlClient;

namespace DataSetDemo
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

                    DataSet ds = new DataSet();

                    SqlDataAdapter studentAdapter =
                        new SqlDataAdapter("SELECT * FROM Students", connection);

                    SqlDataAdapter departmentAdapter =
                        new SqlDataAdapter("SELECT * FROM Departments", connection);

                    studentAdapter.Fill(ds, "Students");

                    departmentAdapter.Fill(ds, "Departments");

                    Console.WriteLine("===== Students =====\n");

                    foreach (DataRow row in ds.Tables["Students"].Rows)
                    {
                        Console.WriteLine(
                            $"{row["Id"]}  {row["Name"]}  {row["Department"]}  {row["Marks"]}"
                        );
                    }

                    Console.WriteLine();

                    Console.WriteLine("===== Departments =====\n");

                    foreach (DataRow row in ds.Tables["Departments"].Rows)
                    {
                        Console.WriteLine(
                            $"{row["DeptId"]}  {row["DeptName"]}"
                        );
                    }

                    Console.WriteLine();

                    Console.WriteLine("Total Tables : " + ds.Tables.Count);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
