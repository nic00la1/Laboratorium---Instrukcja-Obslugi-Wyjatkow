using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ZADANIE 1 ===");
        Zadanie1_Dzielenie();

        Console.WriteLine("\n=== ZADANIE 2 ===");
        Zadanie2_Pierwiastek();

        Console.WriteLine("\n=== ZADANIE 3 ===");
        OtworzPlik();

        Console.WriteLine("\n=== ZADANIE 4 ===");
        StartApp();
    }


    // ===== ZADANIE 1 =====
    static void Zadanie1_Dzielenie()
    {
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double b = double.Parse(Console.ReadLine());

            double wynik = a / b;
            Console.WriteLine($"Wynik dzielenia: {wynik}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Błąd: Nie można dzielić przez zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Wprowadź poprawne liczby!");
        }
    }

    // ===== ZADANIE 2 =====
    static void Zadanie2_Pierwiastek()
    {
        try
        {
            Console.Write("Podaj liczbę: ");
            double liczba = double.Parse(Console.ReadLine());

            double wynik = ObliczPierwiastek(liczba);
            Console.WriteLine($"Pierwiastek kwadratowy z {liczba} = {wynik}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Wprowadź poprawną liczbę!");
        }
    }

    static double ObliczPierwiastek(double x)
    {
        if (x < 0)
            throw new ArgumentException("Liczba nie może być ujemna!");
        return Math.Sqrt(x);
    }

    // ===== ZADANIE 3 =====
    static void OtworzPlik()
    {
        FileStream file = null;

        try
        {
            file = new FileStream("dane.txt", FileMode.Open);
            Console.WriteLine("Plik został otwarty pomyślnie!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Błąd: Plik 'dane.txt' nie istnieje!");
        }
        finally
        {
            if (file != null)
                file.Close();

            Console.WriteLine("Zamykam zasoby...");
        }
    }

    // ===== ZADANIE 4 =====
    static void StartApp()
    {
        try
        {
            Console.WriteLine("Uruchamiam aplikację...");

            Random rand = new Random();
            int los = rand.Next(0, 2); // 0 lub 1

            if (los == 0)
                throw new InvalidOperationException("Wystąpił nieoczekiwany błąd podczas działania aplikacji.");

            Console.WriteLine("Aplikacja działa poprawnie!");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Zamykanie aplikacji...");
        }

        // ===== ZADANIE 5 ======
        static void Zadanie5_ZagniezdzoneTryCatch()
        {
            try
            {
                Console.Write("Podaj liczbę: ");
                int liczba = int.Parse(Console.ReadLine());
                Console.WriteLine($"Wpisałaś liczbę: {liczba}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Niepoprawny format liczby. Spróbuj ponownie.");

                try
                {
                    Console.Write("Podaj liczbę ponownie: ");
                    int liczba = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Teraz wpisałaś liczbę: {liczba}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd ponownie: wprowadzono niepoprawną liczbę. Koniec programu.");
                }
            }
        }
    }
}
