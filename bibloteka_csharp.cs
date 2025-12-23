using System;
using System.Collections.Generic;

namespace WirtualnaBiblioteka
{
    // Klasa Book (odpowiednik z Pythona)
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public string GetInfo()
        {
            string status = IsAvailable ? "Dostepna" : "Wypozyczona";
            return string.Format("'{0}' - {1} [{2}]", Title, Author, status);
        }
    }

    // Klasa Library zarządzająca kolekcją
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author)
        {
            books.Add(new Book(title, author));
            Console.WriteLine("Dodano ksiazke do systemu.");
        }

        public void ShowBooks()
        {
            Console.WriteLine("\n--- LISTA KSIAZEK ---");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, books[i].GetInfo());
            }
        }

        public void LoanBook(int index, string memberName)
        {
            if (index >= 0 && index < books.Count)
            {
                if (books[index].IsAvailable)
                {
                    books[index].IsAvailable = false;
                    Console.WriteLine("Sukces! Wypozyczono ksiazke '{0}' dla {1}.", books[index].Title, memberName);
                }
                else
                {
                    Console.WriteLine("Blad: Ta ksiazka jest juz wypozyczona.");
                }
            }
            else
            {
                Console.WriteLine("Blad: Nieprawidlowy numer ksiazki.");
            }
        }
    }

    // Klasa główna z menu
    class Program
    {
        static void Main(string[] args)
        {
            Library biblioteka = new Library();

            // Dane startowe
            biblioteka.AddBook("Wiedzmin", "A. Sapkowski");
            biblioteka.AddBook("Hobbit", "J.R.R. Tolkien");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n=== MENU BIBLIOTEKI (C#) ===");
                Console.WriteLine("1. Wyswietl ksiazki");
                Console.WriteLine("2. Dodaj ksiazke");
                Console.WriteLine("3. Wypozycz ksiazke");
                Console.WriteLine("4. Koniec");
                Console.Write("Wybierz opcje: ");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        biblioteka.ShowBooks();
                        break;
                    case "2":
                        Console.Write("Podaj tytul: ");
                        string t = Console.ReadLine();
                        Console.Write("Podaj autora: ");
                        string a = Console.ReadLine();
                        biblioteka.AddBook(t, a);
                        break;
                    case "3":
                        biblioteka.ShowBooks();
                        Console.Write("Podaj numer ksiazki: ");
                        if (int.TryParse(Console.ReadLine(), out int indeks))
                        {
                            Console.Write("Podaj imie czytelnika: ");
                            string osoba = Console.ReadLine();
                            biblioteka.LoanBook(indeks, osoba);
                        }
                        else
                        {
                            Console.WriteLine("Blad: Podaj poprawna liczbe.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Zamykanie systemu...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybor.");
                        break;
                }
            }
        }
    }
}