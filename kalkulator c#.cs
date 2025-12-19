using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Prosty Kalkulator w jezyku C#");

            
            Console.Write("Podaj pierwszą liczbę: ");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Podaj drugą liczbę: ");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Wybierz operację (+, -, *, /): ");
            string operacja = Console.ReadLine();

            double wynik = 0;
            bool poprawnaOperacja = true;

            
            if (operacja == "+")
            {
                wynik = liczba1 + liczba2;
            }
            else if (operacja == "-")
            {
                wynik = liczba1 - liczba2;
            }
            else if (operacja == "*")
            {
                wynik = liczba1 * liczba2;
            }
            else if (operacja == "/")
            {
                
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                    poprawnaOperacja = false;
                }
            }
            else
            {
                Console.WriteLine("Błąd: Nieznana operacja.");
                poprawnaOperacja = false;
            }

            
            if (poprawnaOperacja)
            {
                Console.WriteLine($"Wynik: {wynik}");
            }

            
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wyjść...");
            Console.ReadKey();
        }
    }
}