//Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
//Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
//Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
//Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch-finally do obsługi wyjątków.

while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "q")
        break;
    try
    {
        int n = int.Parse(input);
        if(n<0)
        {
            throw new ArgumentOutOfRangeException("Liczba jest ujemna.nie można obliczyć pierwiastka");
        }
        double sqrRoot = Math.Sqrt(n);
        Console.WriteLine($"pierwiastek z {n} wynosi {sqrRoot}");
    }
    catch(FormatException)
    {
        Console.WriteLine("Błąd: Wprowadzona wartośc nie jest liczbą całkowitą");
    }
    catch(ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"Błąd: {ex.Message}");
    }
}
