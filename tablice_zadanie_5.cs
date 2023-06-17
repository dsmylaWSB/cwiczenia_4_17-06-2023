Random rnd = new Random();
int[] tablica = { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

Console.WriteLine(String.Join(", ", tablica));

for (int i = 0; i < tablica.Length - 1; i++)
{
    // Najmniejszy element w nieposortowanej tablicy
    int min_idx = i;
    for (int j = i + 1; j < tablica.Length; j++)
        if (tablica[j] < tablica[min_idx])
            min_idx = j;

    //Znaleziony najmniejszy element przerzucamy na pierwszy element
    int temp = tablica[min_idx];
    tablica[min_idx] = tablica[i];
    tablica[i] = temp;
}

Console.WriteLine(String.Join(", ", tablica));

