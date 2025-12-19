using System;

namespace KonwerterTemperatur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konwerter Temperatur (C ↔ F)");
            Console.WriteLine("Wybierz kierunek konwersji:");
            Console.WriteLine("C - zamiana stopni Celsjusza na Fahrenheit");
            Console.WriteLine("F - zamiana stopni Fahrenheita na Celsjusza");

            Console.Write("Twój wybór (C/F): ");
            string wybor = Console.ReadLine().ToUpper();

            try
            {
                if (wybor == "C")
                {
                    Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
                    double celsjusz = double.Parse(Console.ReadLine());

                    double fahrenheit = (celsjusz * 1.8) + 32;
                    Console.WriteLine("{0}°C to inaczej {1:F2}°F", celsjusz, fahrenheit);
                }
                else if (wybor == "F")
                {
                    Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
                    double fahrenheit = double.Parse(Console.ReadLine());

                    double celsjusz = (fahrenheit - 32) / 1.8;
                    Console.WriteLine("{0}°F to inaczej {1:F2}°C", fahrenheit, celsjusz);
                }
                else
                {
                    Console.WriteLine("Błąd: Wybrano nieprawidłową opcję.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Wprowadzono nieprawidłową wartość liczbową.");
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}