def zad1():
    print("===KALKULATOR PROSTY===")
    liczba1 = float(input("Wpisz pierwszą liczbę: "))
    liczba2 = float(input("Wpisz drugą liczbę: "))
    print("Wybierz typ operacji na liczbach \n * = mnożenie \n / = dzielenie \n + = dodawanie \n - = odejmowanie :")
    operacja = input()

    if operacja == "*":
        print(f"Wynik mnożenia: {liczba1 * liczba2}")
    elif operacja == "/":
        if liczba2 == 0:
            print("Nie można dzielić przez zero!")
        else:
            print(f"Wynik dzielenia: {liczba1 / liczba2}")
    elif operacja == "+":
        print(f"Wynik dodawania: {liczba1 + liczba2}")
    elif operacja == "-":
        print(f"Wynik odejmowania: {liczba1 - liczba2}")
    else:
        print("Błędny znak operacji!")


def zad2():
    print("===KONWERTER TEMPERATUR===")
    print("Najpierw wybierz kierunek konwersji\nJeśli chcesz przeliczyć stopnie Celsjusza na Fahrenheity wpisz 'c'\n"
          "Jeśli chcesz przeliczyć stopnie Fahrenheita na Celsjusza wpisz 'f'")
    kierunek = input().upper()
    temp = float(input("Podaj temperature: "))

    if kierunek == "C":
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik:.2f}°F")
    elif kierunek == "F":
        wynik = (temp - 32) / 1.8
        print(f"{temp}°F = {wynik:.2f}°C")
    else:
        print("Użyto nieprawidłowego symbolu skali temperatury.")


def zad3():
    print("===KALKULATOR ŚREDNIEJ OCEN===")
    liczba_ocen = int(input("Podaj liczbę ocen: "))

    suma = 0.0

    for i in range(1, liczba_ocen + 1):
        ocena = float(input(f"Podaj ocenę nr {i} (1-6): "))
        suma += ocena

    srednia = suma / liczba_ocen
    print(f"\nŚrednia ocen: {srednia:.2f}")
    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")



def main():
    while(True):
        print("")
        print("\n=============================")
        print("1. Kalkulator prosty")
        print("2. Konwerter temperatur")
        print("3. Kalkulator średniej ocen")
        print("0. Wyjście z programu")
        print("=============================")

        wybor = input("Wybierz program: ")

        match wybor:
            case "1":
                zad1()
            case "2":
                zad2()
            case "3":
                zad3()
            case "0":
                print("Zamykanie...")
                break
            case _:
                print("Nieprawidłowy wybór.")


if __name__ == "__main__":
    main()