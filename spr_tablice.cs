//grupa 1
//Napisz program, który:

//Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury
//Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole kwadratu to:
//P=a2

//Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód kwadratu to:
//O=4a

//W funkcji Main:
//Deklaruje zmienną n i przypisuje jej wartość 5.
//Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
//Wyświetla na ekranie zawartość tablicy tablica.

//Dla każdego elementu tablicy tablica:
//Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
//Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.

//Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
//Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu

static int[] UtworzTabliceLiczb1(int n1)
{
    int[] tablica1 = new int[n1];
    for(int i = 1; i < 11; i++)
    {
        System.Console.WriteLine($" Podaj liczbę dla elementu {i+1}");
        if(int.TryParse(Console.ReadLine(), out int liczba1) && liczba1 >= 1 && liczba1 <= 10)
        {
            tablica1[i] = liczba1;
        }
        else
        {
            System.Console.WriteLine("podałeś złą liczbę. podaj liczbę z zakresu 1 do 10");
            i--;
        }
    }
    return tablica1;
}

static int ObliczPole1(int a1)
{
    return a1*a1;
}

static int ObliczObwod1(int a1)
{
    return 4*a;
}

int n1 = 5;
int[] n1 = UtworzTabliceLiczb1(n1)

static internal ObliczenieIPodanieInfo(int bok1)
{
    int pole1 = ObliczPole1(bok);
    int obwod1 = ObliczObwod1(bok);
    System.Console.WriteLine($"pole kwadratu o boku{bok1} to {pole1}");
    System.Console.WriteLine($"obwód kwadratu o boku {bok1} to {obwod1}");
}

system.Console.WriteLine("zawartość tablicy");

for(int i = 0; tablica1.Length; i++)
{
    System.Console.WriteLine($"Element{i+1}: {tablica1[i]}");
    System.Console.Write(ObliczenieIPodanieInfo(tablica1[i]));
}
