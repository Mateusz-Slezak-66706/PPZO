using System;

class Program
{
    static void Main()
    {
        int reset = 0;

        while (reset == 0)
        {
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Zakończ");
            Console.Write("Wybierz rodzaj działania: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Wybrano dodawanie");
                Console.Write("Podaj pierwszą liczbę: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine(x + y);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Wybrano odejmowanie");
                Console.Write("Podaj pierwszą liczbę: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine(x - y);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Wybrano mnożenie");
                Console.Write("Podaj pierwszą liczbę: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine(x * y);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Wybrano dzielenie");
                Console.Write("Podaj pierwszą liczbę: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                double y = double.Parse(Console.ReadLine());

                if (y == 0)
                {
                    Console.WriteLine("Nie można dzielić przez 0.");
                }
                else
                {
                    Console.WriteLine(x / y);
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Zakończono program.");
                break;
            }
            else
            {
                Console.WriteLine("Niepoprawny wybór");
            }

            Console.WriteLine(); // pusta linia dla czytelności
        }
    }
}
