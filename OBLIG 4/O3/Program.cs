namespace O3
{
    class Program
    {
        const int maks = 10;
        static void Main(string[] args)
        {
            List<Bil> biler = new List<Bil>();

            for (int i = 0; i <= maks; i++)
            {
                Console.WriteLine("Oppgi biltype:");
                string biltype = Console.ReadLine();
                Console.WriteLine("Oppgi eier:");
                string eier = Console.ReadLine();
                Console.WriteLine("Oppgi skilt:");
                string skilt = Console.ReadLine();
                Bil bil = new Bil(biltype, eier, skilt);
                biler.Add(bil);
                Console.WriteLine();
            }

            foreach (Bil bil in biler)
            {
                bil.show();
            }
            Console.WriteLine("        ");

            biler.Sort(Order1);
            foreach (Bil bil in biler)
            {  
                bil.show(); 
            }
            Console.WriteLine("        ");

            biler.Sort(Order2);
            foreach (Bil bil in biler)
            {
                bil.show();
            }
            Console.WriteLine("        ");

            Console.ReadKey();
        }

        static int Order1(Bil x, Bil y)
        { 
           return x.Skilt.CompareTo(y.Skilt);
        }

        static int Order2(Bil x, Bil y)
        {
            return x.Eier.Length - y.Eier.Length;
        }
    }
}
