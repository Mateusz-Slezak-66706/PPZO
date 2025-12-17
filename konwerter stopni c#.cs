using System;

class Program
{
    static void Main()
    {
        int reset = 0;

        while (reset == 0)
        {
            Console.WriteLine("\nC - stopnie Celsjusza na Fahrenheity");
            Console.WriteLine("F - stopnie Fahrenheita na Celsjusze");
            Console.Write("Twój wybór: ");

            string choice = Console.ReadLine().ToLower();

            if (choice == "f")
            {
                Console.Write("Podaj ilość stopni Fahrenheita: ");
                double f = double.Parse(Console.ReadLine());
                double c = (f - 32) / 1.8;
                Console.WriteLine(c);
            }
            else if (choice == "c")
            {
                Console.Write("Podaj ilość stopni Celsjusza: ");
                double c = double.Parse(Console.ReadLine());
                double f = (c * 1.8) + 32;
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("Błąd");
            }
        }
    }
}