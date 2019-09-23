using System;

namespace Exercise6
{
    class Program
    {
        static int ToPercentage(double input)
        {

            input= Math.Round(input, 0);
            int output = (int)input;
            return output;
        }
        static void Main(string[] args)
        {
            Console.Write("Ett decimaltal tack! ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ditt decimaltal {0}, blir {1} som heltal.",userInput, ToPercentage(userInput));
            Console.WriteLine("Tack o bock!");
        }
    }
}
