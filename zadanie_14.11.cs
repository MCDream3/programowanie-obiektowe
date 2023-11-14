// funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę CreateArray()

static int[] CreateArray(string name)
{
    int size = 0;
    try
    {
        size = int.Parse(Console.ReadLine());
        if (size <= 0) throw new ArgumentException("Rozmiar tablicy ma być dodatni");
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine("");
    }
    int[] array = new int[size];
    return array;
}

// funkcja statyczna, która ustawia elementy tablicy SetArray()

static void SetArray(int[]array, string name)
{
    for (int i = 0; i < array.Length; i++)
    {

    }
}

// funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()

static void DisplayArray()
{

}
