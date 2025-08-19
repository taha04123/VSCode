using System;

class Program
{
    static void Main(string[] args)
    {
        // Antall noder
        int antallNoder = 5;

        // Definer MAX_INT som et veldig stort tall (her brukt int.MaxValue)
        int MAX_INT = int.MaxValue;

        // Opprett en vektsmatrise
        int[,] vektMatrise = new int[antallNoder, antallNoder];

        // Initialiser vektsmatrisen
        for (int i = 0; i < antallNoder; i++)
        {
            for (int j = 0; j < antallNoder; j++)
            {
                if (i == j)
                {
                    vektMatrise[i, j] = 0; // Diagonal-elementer settes til 0
                }
                else
                {
                    vektMatrise[i, j] = MAX_INT; // Ingen kant mellom i og j
                }
            }
        }

        // Legg til kanter med vekt (eksempel: mellom node 0 og 1 med vekt 10)
        vektMatrise[0, 1] = 10;
        vektMatrise[1, 2] = 15;
        vektMatrise[2, 3] = 20;
        vektMatrise[3, 4] = 25;
        vektMatrise[4, 0] = 30;

        // Skriv ut vektsmatrisen
        Console.WriteLine("Vektsmatrise:");
        for (int i = 0; i < antallNoder; i++)
        {
            for (int j = 0; j < antallNoder; j++)
            {
                if (vektMatrise[i, j] == MAX_INT)
                {
                    Console.Write("INF\t"); // INF representerer "ingen kant"
                }
                else
                {
                    Console.Write(vektMatrise[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}
