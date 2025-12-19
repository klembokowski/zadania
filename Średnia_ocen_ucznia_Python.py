print("Kalkulator Średniej Ocen")
try:
    liczba_ocen = int(input("Ile ocen chcesz wprowadzić? "))
    suma = 0
    for i in range(liczba_ocen):
        ocena = float(input("Podaj ocenę nr {}: ".format(i + 1)))
        suma = suma + ocena
    if liczba_ocen > 0:
        srednia = suma / liczba_ocen
        print("\nŚrednia: {:.2f}".format(srednia))
        if srednia >= 3.0:
            print("Uczeń zdał.")
        else:
            print("Uczeń nie zdał.")
    else:
        print("Błąd: Liczba ocen musi być większa od zera.")

except ValueError:
    print("Błąd: Wprowadzono nieprawidłowe dane (podaj liczby).")
