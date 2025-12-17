using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę ocen: ");
        int liczbaOcen = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < liczbaOcen; i++)
        {
            while (true)
            {
                Console.Write($"Podaj ocenę {i + 1} (1–6): ");
                double ocena = double.Parse(Console.ReadLine());

                if (ocena >= 1 && ocena <= 6)
                {
                    suma += ocena;
                    break;
                }
                else
                {
                    Console.WriteLine("Błąd! Ocena musi być w zakresie od 1 do 6.");
                }
            }
        }

        double srednia = suma / liczbaOcen;

        if (srednia >= 3)
        {
            Console.WriteLine($"Zdałeś! Średnia ocen to: {srednia:F2}");
        }
        else
        {
            Console.WriteLine($"Nie zdałeś! Średnia ocen to: {srednia:F2}");
        }
    }
}