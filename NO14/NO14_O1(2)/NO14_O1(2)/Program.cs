namespace NO14_O1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette programmet rekner ut summen av heiltall 'n'.");
            int n = Convert.ToInt32(Console.ReadLine());

            //O2
            if (n < 0)
            {
                //Console.WriteLine("n skal vere positiv");
                long sum(int n)
                {
                    if (n == 0) return 0;
                    return (n * (-n + 1)) / 2;
                }
                long summen = sum(n);
                Console.WriteLine($"Summen av n = {n} er: {summen}");
            }
            //O1
            else
            {
                long sum(int n)
                {
                    if (n == 0) return 0;
                    return (n * (n + 1)) / 2;
                }
                long summen = sum(n);
                Console.WriteLine($"Summen av n = {n} er: {summen}");
            }


        }
    }
}
