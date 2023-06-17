
Random rnd = new Random();
int[] tablica = { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

Console.WriteLine(String.Join(", ", tablica));

int max = tablica[0];
int min = tablica[0];
for (int i = 0; i < tablica.Length; i++)
{
    if (max < tablica[i])
        max = tablica[i];

    if(min > tablica[i])
        min = tablica[i];
}

Console.WriteLine($"Największa wartość to: {max}\n" +
                  $"Najmniejsza wartość to: {min}");