print("Konwerter Temperatur")
print("Wybierz kierunek konwersji:")
print("C - zamiana Celsjusza na Fahrenheit")
print("F - zamiana Fahrenheita na Celsjusza")

kierunek = input("Twój wybór (C/F): ").upper()

try:
    if kierunek == "C":
        celsjusz = float(input("Podaj temperaturę w stopniach Celsjusza: "))
        fahrenheit = celsjusz * 1.8 + 32
        print("{}°C = {}°F".format(celsjusz, fahrenheit))

    elif kierunek == "F":
        fahrenheit = float(input("Podaj temperaturę w stopniach Fahrenheita: "))
        celsjusz = (fahrenheit - 32) / 1.8
        print("{}°F = {}°C".format(fahrenheit, celsjusz))

    else:
        print("Błąd: Nieprawidłowy wybór. Wybierz C lub F.")

except ValueError:
    print("Błąd: Proszę podać poprawną wartość liczbową.")
