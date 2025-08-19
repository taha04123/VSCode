namespace fakultet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int fakultet(int n)
            {
                if (n == 0) return 1;
                else return n * fakultet(n - 1);
            }
            int resultat = fakultet(n);

            Console.WriteLine(resultat);
        }
    }
}
