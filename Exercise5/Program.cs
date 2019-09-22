using System;

namespace Exercise5
{
    class Program
    {
        static double AddVat(double input, int inputVat)
        {
            double percent = 100;
            double vat = inputVat/percent + 1;
            double withVat = input * vat;
            return withVat;
        }
        static void Main(string[] args)
        {
            Console.Write("Vad är priset utan moms? ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hur många % ligger momesen på? ");
            int vat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}kr med {1}% moms, kostar varan {2}kr",price, vat, AddVat(price, vat));

        }
    }
}
