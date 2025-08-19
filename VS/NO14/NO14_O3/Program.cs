namespace NO14_O3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette er eit program som reknar ut fibonacci-sekvens.");
            Console.Write("Skriv n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            

            long fib(int n)
            {
                if (n >= 2) return fib(n - 1) + fib(n - 2);
                else
                {
                    if (n == 1) return 1;
                    else return 0; // n == 0
                }
            }
            Console.WriteLine($"\nF{n}= {fib(n)}");
        }
    }
}
