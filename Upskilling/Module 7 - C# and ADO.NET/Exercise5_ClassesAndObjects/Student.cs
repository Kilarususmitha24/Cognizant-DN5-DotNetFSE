using System;

namespace ClassesAndObjects
{
    class Student
    {
        public int Id;
        public string Name;
        public double CGPA;

        public Student()
        {
            Console.WriteLine("Student Object Created");
        }

        public Student(int id, string name, double cgpa)
        {
            Id = id;
            Name = name;
            CGPA = cgpa;
        }

        public void Display()
        {
            Console.WriteLine("Student ID   : " + Id);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("CGPA         : " + CGPA);
        }
    }
}
