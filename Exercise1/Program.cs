using System;

namespace Exercise1
{
    class Program
    {
        static string Hello(string name)
        {
            Console.WriteLine("Hej {0}",name);
            return name;

        }
        static void Main(string[] args)
        {
            Console.Write("Vad är ditt namn? ");
            string name = Console.ReadLine();
            Hello(name);
        }
    }
}
