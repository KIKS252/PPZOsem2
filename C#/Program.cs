using System;

class Program
{
    static void Main()
    {
        string wybor = "0";
        do
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("1. Kalkulator prosty");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Kalkulator średniej ocen");
            Console.WriteLine("0. Wyjście z programu");
            Console.WriteLine("=============================");
            Console.Write("Wybierz program: ");

            wybor = Console.ReadLine();


            switch (wybor)
            {
                case "1":
                    Zad1();
                    break;
                case "2":
                    Zad2();
                    break;
                case "3":
                    Zad3();
                    break;
                case "0":
                    Console.WriteLine("Zamykanie...");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        } while (wybor != "0");
    }

    static void Zad1()
    {
        Console.WriteLine("===KALKULATOR PROSTY===");
        Console.Write("Wpisz pierwszą liczbę: ");
        double liczba1 = double.Parse(Console.ReadLine());
        Console.Write("Wpisz drugą liczbę: ");
        double liczba2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Wybierz typ operacji na liczbach \n * = mnożenie \n / = dzielenie \n + = dodawanie \n - = odejmowanie :");
        string operacja = Console.ReadLine();

        if (operacja == "*")
        {
            Console.WriteLine($"Wynik mnożenia: {liczba1 * liczba2}");
        }
        else if (operacja == "/")
        {
            if (liczba2 == 0)
            {
                Console.WriteLine("Nie można dzielić przez zero!");
            }
            else
            {
                Console.WriteLine($"Wynik dzielenia: {liczba1 / liczba2}");
            }
        }
        else if (operacja == "+")
        {
            Console.WriteLine($"Wynik dodawania: {liczba1 + liczba2}");
        }
        else if (operacja == "-")
        {
            Console.WriteLine($"Wynik odejmowania: {liczba1 - liczba2}");
        }
        else 
            { Console.WriteLine("Błędny znak operacji!"); }
    }

    static void Zad2()
    {
        Console.WriteLine("===KONWERTER TEMPERATUR===");
        Console.WriteLine("Najpierw wybierz kierunek konwersji\nJeśli chcesz przeliczyć stopnie Celsjusza na Fahrenheity wpisz 'c'\n" +
            "Jeśli chcesz przeliczyć stopnie Fahrenheita na Celsjusza wpisz 'f'");
        string kierunek = Console.ReadLine().ToUpper();
        Console.Write("Podaj temperature: ");
        double temp = double.Parse(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32; //C na F
            Console.WriteLine($"{temp}°C = {wynik:F2}°F");
        }
        else if (kierunek == "F")
        {
            double wynik = ((temp - 32) / 1.8); //F na C
            Console.WriteLine($"{temp}°F = {wynik:F2}°C");
        }
        else { Console.WriteLine("Użyto nieprawidłowego symbolu skali temperatury."); }
    }

    static void Zad3()
    {
        Console.WriteLine("===KALKULATOR ŚREDNIEJ OCEN===");
        Console.Write("Podaj liczbę ocen: ");
        int liczbaOcen = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write($"Podaj ocenę nr {i} (1-6): ");
            double ocena = double.Parse(Console.ReadLine());
                suma += ocena;
        }
        double srednia = suma / liczbaOcen;
        Console.WriteLine($"\nŚrednia ocen: {srednia:F2}");
        if(srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zdał.");
        }
        else
        {
            Console.WriteLine("Uczeń nie zdał.");
        }
    }
}