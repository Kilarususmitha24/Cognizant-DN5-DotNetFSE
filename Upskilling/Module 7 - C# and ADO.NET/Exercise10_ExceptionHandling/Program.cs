using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Exception Handling Demo =====");

            try
            {
                Console.Write("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num2 == 0)
                {
                    throw new DivideByZeroException("Second number cannot be zero.");
                }

                int result = num1 / num2;

                Console.WriteLine("Result = " + result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Input! Please enter only numbers.");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("Finally Block Executed.");
            }

            Console.WriteLine();
            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
