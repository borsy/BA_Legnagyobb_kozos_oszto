using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kérem, adjon meg két egész számot:");

        // Felhasználótól bekérjük az első számot
        int szam1 = Convert.ToInt32(Console.ReadLine());

        // Felhasználótól bekérjük a második számot
        int szam2 = Convert.ToInt32(Console.ReadLine());

        // Kiszámoljuk a legnagyobb közös osztót
        int legnagyobbKozosOszto = LegnagyobbKozosOszto(szam1, szam2);

        // Kiírjuk az eredményt
        Console.WriteLine($"A legnagyobb közös osztó: {legnagyobbKozosOszto}");

        Console.ReadLine();
    }

    // Függvény a legnagyobb közös osztó kiszámolására
    static int LegnagyobbKozosOszto(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
