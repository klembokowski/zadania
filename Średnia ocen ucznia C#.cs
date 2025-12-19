using System;

namespace SredniaOcen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator Średniej Ocen");

            try
            {
                
                Console.Write("Ile ocen chcesz wprowadzić? ");
                int liczbaOcen = int.Parse(Console.ReadLine());

                double suma = 0;

              
                for (int i = 1; i <= liczbaOcen; i++)
                {
                    Console.Write("Podaj ocenę nr {0}: ", i);
                    double ocena = double.Parse(Console.ReadLine());
                    suma += ocena;
                }

               
                if (liczbaOcen > 0)
                {
                    double srednia = suma / liczbaOcen;

                    Console.WriteLine("\nŚrednia: {0:F2}", srednia);

                    if (srednia >= 3.0)
                    {
                        Console.WriteLine("Uczeń zdał.");
                    }
                    else
                    {
                        Console.WriteLine("Uczeń nie zdał.");
                    }
                }
                else
                {
                    Console.WriteLine("Błąd: Liczba ocen musi być większa od zera.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Wprowadzono nieprawidłowe dane. Podaj liczby.");
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wyjść...");
            Console.ReadKey();
        }
    }
}