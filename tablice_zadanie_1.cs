void swap(int[] tablica, int i, int j)
{
    int temp = tablica[i];
    tablica[i] = tablica[j];
    tablica[j] = temp;
}

Random rnd = new Random();
int[] tablica = { rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100) };

Console.WriteLine(String.Join(',', tablica));


for (int i = 0; i < tablica.Length / 2; i++)
{
    swap(tablica, i, tablica.Length - i - 1);
}

Console.WriteLine(String.Join(',', tablica));
