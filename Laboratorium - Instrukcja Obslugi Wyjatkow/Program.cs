try
{
    int a = 10;
    int b = 0;
    int c = a / b; // Tutaj wystąpi DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Nie można dzielić przez zero! - Cholero!");
}

// Throw - Służy do ręcznego zgłoszenia wyjątku, np. kiedy chcesz wymusić
// zakończenie działania funkcji w nieprawidłowej sytuacji

int x = 10;

if (x < 0)
{
    throw new ArgumentException("Liczba nie może być ujemna");
}

// Blok finally wykona się zawsze, niezależnie od tego, czy wystąpił wyjątek,
// czy nie. Używany np. do zamykania plików, połączeń, zwalniania zasobów.
FileStream file = null;
try
{
    file = new FileStream("dane.txt", FileMode.Open);
    // operacje na pliku
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Plik nie istnieje! Tworzę nowy...");
    file = new FileStream("dane.txt", FileMode.Create);
}
finally
{
    if (file != null)
        file.Close();
}

// try-catch-finally - Połączenie wszystkich trzech elementów 
// obsługa błędów + sprzątanie zasobów
try
{
    int[] tab = { 1, 2, 3 };
    Console.WriteLine(tab[5]); // błąd
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Błąd: {ex.Message}");
}
finally
{
    Console.WriteLine("Zawsze się wykona - nawet po błędzie");
}


// ============= ZADANIA PRAKTYCZNE ================
// Zadanie 1 - Dzielenie z obsługą błędów
// Napisz program, który: 
// Wczytuje dwie liczby od użytkownika,
// dzieli je i wyświetla wynik,
// jeśli druga liczba to 0, przechwytuje wyjątek i informuje użytkownika,
// że nie można dzielić przez zero.
try
{
    // Wczytanie dwóch liczb od użytkownika
    Console.Write("Podaj pierwszą liczbę: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Podaj drugą liczbę: ");
    double b = double.Parse(Console.ReadLine());

    // Próba wykonania dzielenia
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