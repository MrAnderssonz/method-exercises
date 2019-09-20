using System;

namespace Exercise2
{
    class Program
    {
        static string MakeTwoIntoOne (string one, string two)
        {
            string TwoInOne = one + " " + two;
            return TwoInOne;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello vän!");
            Console.Write("Skriv något kul: ");
            string input1 = Console.ReadLine();
            Console.Write("Skriv något tråkigt ");
            string input2 = Console.ReadLine();

           Console.WriteLine(MakeTwoIntoOne(input1, input2));

        }
    }
}
