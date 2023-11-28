int[,] tablica = null;
int n = 0;

while(true)
{
    Console.WriteLine("Wybierz funkcję statyczną:");
    Console.WriteLine("1. WczytajLiczbę");
    Console.WriteLine("2. UtworzTablicę");
    Console.WriteLine("3. WypelnijTablicę");
    Console.WriteLine("4. WyswietlTablicę");
    Console.WriteLine("5. ObliczSumę");
    Console.WriteLine("6. Zakończ");
    string wybor = System.Console.ReadLine();
    switch(wybor)
    {
        case "1":
            n = WczytajLiczbe();
            break;
        case "2":
            tablica = UtworzTablice(n);
            break;
        case "3":
            WypelnijTablice(tablica);
            break;
        case "4":
            WyswietlTablice(tablica);
            break;
        case "5":
            ObliczISum(tablica);
            break;
        case "6":
            return 0;
    }
}

static int WczytajLiczbe()
{
    int result;
    while(true)
    {
        System.Console.WriteLine("podaj liczbę lub q aby zakończyć");
        string input = System.Console.ReadLine();
        if(input.ToLower() == "q")
            Environment.Exit(0)
        if(int.TryParse(input,out result) && result > 0)
            return result;
    }
}
static int[,] UtworzTablice(int n)
{
    int[,] tablica = new int[n,n];
    System.Console.WriteLine($"utworzono tablicę o wymiarach {n} * {n}");
    return tablica;
}
static void WypelnijTablice(int[,] tablica)
{
    if(tablica == null)
        return;
}
System.Console.WriteLine("podaj dolną granicę");
int dolnaGranica = WczytajLiczbe();

System.Console.WriteLine("podaj górną granicę");
int gornaGranica = WczytajLiczbe();

Random r = new Random();
for(int i = 0; i < tablica.GetLength(0); i++)
{
    for(int j = 0; j < tablica.GetLength(1); j++)
    {
        tablica[i,j] = random.Next(dolnaGranica,gornaGranica)
    }
}

static int ObliczISum(int[,] tablica)
{
    if(tablica == null)
    {
        System.Console.WriteLine("najpierw utwórz i wypełnij tablicę");
        return;
    }
    int suma = 0;
    for(int i = 0; i < tablica.GetLength(0); i++)
    {
        suma += tablica[i,i]
    }
    System.Console.WriteLine($"suma elementów głównej tablicy{suma}");
}
