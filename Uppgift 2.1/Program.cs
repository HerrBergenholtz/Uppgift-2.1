using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din favoritbok?");
            string bok = Console.ReadLine();
            Console.WriteLine("Du gillar " + bok);

            Console.ReadKey();
        }
    }
}