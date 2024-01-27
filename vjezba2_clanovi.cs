using System;

class Program
{
    static void Main()
    {
        int[] niz1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] niz2 = { 1, 3, 3, 4, 5, 6, 7, 8, 9, 10 };

        int brojClanova = 0;

        for (int i = 0; i < niz1.Length; i++)
        {
            if (niz1[i] == niz2[i])
            {
                brojClanova++;
            }
        }

        Console.WriteLine("Broj članova na istom indeksu sa istom vrijednošću: " + brojClanova);
    }
}
