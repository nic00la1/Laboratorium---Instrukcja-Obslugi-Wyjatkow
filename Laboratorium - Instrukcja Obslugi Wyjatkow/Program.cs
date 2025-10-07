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