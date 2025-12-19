try:
    liczba1 = float(input("Podaj pierwsza liczbe: "))
    liczba2 = float(input("Podaj druga liczbe: "))
    operacja = input("Wybierz operacje (+, -, *, /): ")

    if operacja == "+":
        wynik = liczba1 + liczba2
        print("Wynik: {}".format(wynik))
    elif operacja == "-":
        wynik = liczba1 - liczba2
        print("Wynik: {}".format(wynik))
    elif operacja == "*":
        wynik = liczba1 * liczba2
        print("Wynik: {}".format(wynik))
    elif operacja == "/":
        if liczba2 != 0:
            wynik = liczba1 / liczba2
            print("Wynik: {}".format(wynik))
        else:
            print("Blad: Nie mozna dzielic przez zero!")
    else:
        print("Blad: Nieznana operacja.")

except ValueError:
    print("Blad: Prosze podac poprawne liczby.")