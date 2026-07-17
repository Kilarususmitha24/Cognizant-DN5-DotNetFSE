using System;
using System.Threading;

namespace MultithreadingDemo
{
    class Program
    {
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread 1 : " + i);
                Thread.Sleep(500);
            }
        }

        static void PrintLetters()
        {
            char ch = 'A';

            while (ch <= 'E')
            {
                Console.WriteLine("Thread 2 : " + ch);
                ch++;
                Thread.Sleep(700);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== Multithreading Demo =====");

            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintLetters);

            thread1.Start();
            thread2.Start();

            // Wait for Threads to Finish
            thread1.Join();
            thread2.Join();

            Console.WriteLine();

            Console.WriteLine("All Threads Completed.");

            Console.WriteLine();

            Console.WriteLine("Program Completed Successfully.");

            Console.ReadKey();
        }
    }
}
