using System;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");

            string ax = Console.ReadLine();
            int a = int.Parse(ax);

            Console.WriteLine("Podaj drugą liczbę");

            string bx = Console.ReadLine();
            int b = int.Parse(bx);

            Console.WriteLine("Podaj numer operacjii do wykonania");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            string liczba = Console.ReadLine();
            int c = int.Parse(liczba);

            if (c == 1)
            {
                Console.WriteLine($"Twój wynik to  {a + b}");

            }
            if (c == 2)
            {
                Console.WriteLine($"Twój wynik to  {a - b}");

            }
            if (c == 3)
            {
                Console.WriteLine($"Twój wynik to  {a * b}");

            }
            if (c == 4)
            {
                Console.WriteLine($"Twój wynik to  {a / b}");

            }


        }
    }
}
