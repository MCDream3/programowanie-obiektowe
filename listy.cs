//tworzenie listy liczb całkowitych

List<int> ints = new List<int>();

//tworzenie listy liczb całkowitych z pocztkowymi elementami, uywajc inicjalizatora kolekcji

List<int> ints1 = new List<int>() {1,2,10,-2};

//dodawanie elementu do listy za pomocą Add()

ints1.Add(1);
ints1.Add(111);

//usuwanie elementu z tablicy za pomocą metody Remove()

ints1.Remove(1);

//wyświetlanie długości tablicy za pomocą metody Count

System.Console.WriteLine("Długość listy: " + ints1.Count);

//wyświetlenie elementów listy

foreach(int i in ints1)
{
    System.Console.WriteLine(i); //2 1 10 -2 1 111
}

ints1.Remove(1);
foreach(int i in ints1)
{
    System.Console.WriteLine(i); //2 10 -2 1 111
}


//zadanie
//Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
//Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
//Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.

static List<int> WygenerujListęLiczb(int rozmiar)
{
    Random r = new Random();
    return Enumerable.Range(1, rozmiar).Select(_ => random.Next(1,101)).ToList();
}
List<int> listaLiczb = WygenerujListęLiczb(10);

static List<int> FiltrujPodzielne(List<int> lista)
{
    return lista.Where(liczba => liczba % 3 == 0 || liczba % 5 == 0).ToList();
}
List<int> listaPodzielnych = FiltrujPodzielne(listaLiczb);

static void WyswietlListe(List<int> lista)
{
    foreach(var liczba in lista)
    {
        System.Console.WriteLine(liczba + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("tablica liczb randomowych od 1 do 100");
System.Console.WriteLine(WyswietlListe(listaLiczb));
System.Console.WriteLine("zwrócenie liczb podzielnych przez 3 lub 5");
System.Console.WriteLine(WyswietlListe(listaPodzielnych));
