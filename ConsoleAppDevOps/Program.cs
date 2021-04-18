using System;

namespace ConsoleAppDevOps
{
    public class Student
    {
        int id;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.SetId(10);
            Console.WriteLine("Hello World !!!"+student.getId());
        }
    }
}
