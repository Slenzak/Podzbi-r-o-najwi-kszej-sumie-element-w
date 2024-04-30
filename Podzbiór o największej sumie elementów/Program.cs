internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        int[] tablica = new int[20];
        int[,] macierz = new int[20, 20];
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = rand.Next(-99,99);
        }
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                macierz[i, j] = rand.Next(-99, 100);
            }
        }
        int ip = 0, ik = 0;
        int ms = tablica[0];
        int bs = 0;
        int ip2 = 0, ik2 = 0;
        int ms2 = macierz[0, 0]; 
        int bs2 = 0; 
        for (int i = 0; i < tablica.Length; i++)
        {
            bs = 0;
            for (int j = i; j < tablica.Length; j++)
            {
                bs += tablica[j];
                if (bs > ms)
                {
                    ms = bs;
                    ip = i;
                    ik = j;
                }
            }
        }
        for (int i = 0; i < 20; i++)
        {
            for (int j = i; j < 20; j++)
            {
                bs = 0;
                for (int k = 0; k < 20; k++)
                {
                    int suma = 0;
                    for (int l = i; l <= j; l++)
                    {
                        suma += macierz[k, l];
                    }
                    bs += suma;
                    if (bs > ms)
                    {
                        ms = bs;
                        ip = i;
                        ik = j;
                    }
                    if (bs < 0)
                    {
                        bs = 0;
                    }
                }
            }
        }
        Console.WriteLine("Największa suma: " + ms);
        Console.WriteLine("Indeks początku podciągu: " + ip);
        Console.WriteLine("Indeks końca podciągu: " + ik);
        Console.WriteLine("Wylosowana tablica: ");
        for (int i = 0;i < tablica.Length; i++)
        {
            Console.Write(tablica[i]+" ");
        }
        Console.WriteLine("Największa suma podciągu w macierzy: " + ms);
        Console.WriteLine("Pozycja początku podciągu (wiersz, kolumna): (" + ip + ", 0)");
        Console.WriteLine("Pozycja końca podciągu (wiersz, kolumna): (" + ik + ", 19)");
        Console.WriteLine("Wylosowana Macierz: ");
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Console.Write(macierz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

