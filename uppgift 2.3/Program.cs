using System;

namespace Uppgift_2._3
{
    public class Program
    {
        static void Main(string[] Void)
        {
            Console.WriteLine("hur många dagar vill du hyra bilen?");
            int dagar = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("hur många kilometer ska du åka?");
            int kilometer = int.Parse(Console.ReadLine());
            Console.Clear();
            int kostnad = 300 + 500 * (dagar - 1) + kilometer;
            Console.WriteLine($"Det kostar {kostnad} kr att hyra bilen.");
            Console.ReadKey();
        }
    }
}

