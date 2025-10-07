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