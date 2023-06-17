Random rnd = new Random();
int[] tablica = { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

Console.WriteLine(String.Join(", ", tablica));

int temp = 0;

for (int write = 0; write < tablica.Length; write++)
{
    for (int sort = 0; sort < tablica.Length - 1; sort++)
    {
        if (tablica[sort] > tablica[sort + 1])
        {
            temp = tablica[sort + 1];
            tablica[sort + 1] = tablica[sort];
            tablica[sort] = temp;
        }
    }
}

Console.WriteLine(String.Join(", ", tablica));
