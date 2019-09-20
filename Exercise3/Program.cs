using System;

namespace Exercise3
{
    class Program
    {
        static int Addera(int input1, int input2)
        {
            int sum = input1 + input2;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tja");
            Console.Write("Skriv in ett tal: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ett andra tal: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Summan av dina tal {0} och {1} är {2}",input1, input2, Addera(input1, input2));
            
        }
    }
}
