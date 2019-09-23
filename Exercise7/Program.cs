using System;

namespace Exercise7
{
    class Program
    {
        static bool OfAge(int input)
        {
            bool mature = true;
            if (input >= 18)
            {
                mature = true;
            }
            else
            {
                mature = false;
            }
            return mature;
        }
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du min vän? ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (OfAge(input))
            {
                Console.WriteLine("Grattis! du är över myndig och kan hämna i fängelse!");
            }
            else
            {
                Console.WriteLine("Bättre lycka nästa gång din lille plutt! 👶🏼");
            }
        }
    }
}
