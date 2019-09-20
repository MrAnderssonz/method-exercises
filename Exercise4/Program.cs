using System;

namespace Exercise4
{
    class Program
    {
        static double AddVat(double input)
        {
            double withVat = input * 1.25;
            return withVat;
        }
        static void Main(string[] args)
        {
            Console.Write("Vad är priset utan moms? ");
            double withoutVat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Då blir priset med moms: {0}", AddVat(withoutVat));

        }
    }
}
