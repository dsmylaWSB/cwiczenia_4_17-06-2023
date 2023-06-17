Random rnd = new Random();
int[] tablica = { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

Console.WriteLine(String.Join(", ", tablica));


for (int i = 1; i < tablica.Length; ++i)
{
    int current = tablica[i];
    int j = i - 1;

    while (j >= 0 && tablica[j] > current)
    {
        tablica[j + 1] = tablica[j];
        j = j - 1;
    }

    tablica[j + 1] = current;
}

Console.WriteLine(String.Join(", ", tablica));