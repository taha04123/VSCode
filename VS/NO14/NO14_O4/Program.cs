namespace NO14_O4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette er eit program som løyser Tower of Hanoi");

            int n = 4;
            Console.WriteLine($"\nTOH for n == {n}:");
            TOH(n, 'A', 'B', 'C');
            double flytting = (Math.Pow(2, Convert.ToDouble(n)) - 1);
            Console.WriteLine($"Antall flytting: {flytting}");

            n = 2;
            Console.WriteLine($"\nTOH for n == {n}:");
            TOH(n, 'A', 'B', 'C');
            flytting = (Math.Pow(2, Convert.ToDouble(n)) - 1);
            Console.WriteLine($"Antall flytting: {flytting}");

            static void TOH(int n, char start, char mål, char reserve)
            {
                if (n == 1)
                {
                    Console.WriteLine($"Flytt frå {start} til {mål}");
                    return;
                }
                TOH(n - 1, start, reserve, mål);
                Console.WriteLine($"Flytt fra {start} til {mål}");
                TOH(n - 1, reserve, mål, start);
            }
        }
    }
}
