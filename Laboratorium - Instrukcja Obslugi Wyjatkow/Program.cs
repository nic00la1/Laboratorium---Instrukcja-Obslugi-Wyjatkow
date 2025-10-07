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
finally
{
    if (file != null)
        file.Close(); // zawsze się wykona
}