class Book:
    def __init__(self, title, author):
        self.title = title
        self.author = author
        self.is_available = True

    def display_info(self):
        status = "Dostepna" if self.is_available else "Wypozyczona"
        return "'{0}' - {1} [{2}]".format(self.title, self.author, status)


class Member:
    def __init__(self, name):
        self.name = name

    def contact(self):
        return "Czytelnik: {0}".format(self.name)


class Library:
    def __init__(self):
        self.books = []
        self.members = []

    def add_book(self, title, author):
        nowa_ksiazka = Book(title, author)
        self.books.append(nowa_ksiazka)
        print("Dodano ksiazke do systemu.")

    def show_books(self):
        print("\n--- LISTA KSIAZEK ---")
        for i, book in enumerate(self.books):
            print("{0}. {1}".format(i, book.display_info()))

    def loan_book(self, book_index, member_name):
        if 0 <= book_index < len(self.books):
            book = self.books[book_index]
            if book.is_available:
                book.is_available = False
                print("Sukces! Wypozyczono ksiazke '{0}' dla {1}.".format(book.title, member_name))
            else:
                print("Blad: Ta ksiazka jest juz wypozyczona.")
        else:
            print("Blad: Nieprawidlowy numer ksiazki.")


# --- MENU GLOWNE ---

def main():
    biblioteka = Library()
    
    # Dane startowe
    biblioteka.add_book("Wiedzmin", "A. Sapkowski")
    biblioteka.add_book("Hobbit", "J.R.R. Tolkien")

    while True:
        print("\n=== MENU BIBLIOTEKI ===")
        print("1. Wyswietl ksiazki")
        print("2. Dodaj ksiazke")
        print("3. Wypozycz ksiazke")
        print("4. Koniec")
        
        wybor = input("Wybierz opcje: ")

        if wybor == "1":
            biblioteka.show_books()
        
        elif wybor == "2":
            t = input("Podaj tytul: ")
            a = input("Podaj autora: ")
            biblioteka.add_book(t, a)
        
        elif wybor == "3":
            biblioteka.show_books()
            try:
                indeks = int(input("Podaj numer ksiazki do wypozyczenia: "))
                osoba = input("Podaj imie czytelnika: ")
                biblioteka.loan_book(indeks, osoba)
            except ValueError:
                print("Blad: Podaj poprawny numer.")
        
        elif wybor == "4":
            print("Zamykanie systemu...")
            break
        
        else:
            print("Niepoprawny wybor, sprobuj ponownie.")

if __name__ == "__main__":
    main()