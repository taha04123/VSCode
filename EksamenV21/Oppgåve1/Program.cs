namespace Oppgåve1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tur a = new Tur("Ulriken", "Rundeman", 17.0);
            Tur b = new Tur("Rundeman", "Fløyen", 3.0);
            Tur c = new Tur("Ulriken", "Livarden", 17.0);
            Tur d = a + b;
            Tur e = a + c;
            Tur f = new Tur("Ulriken", "Rundeman", 17.0);

            a.turVanskelighetsgrad = Vanskelighetsgrad.Middels;
            d.turVanskelighetsgrad = Vanskelighetsgrad.Middels;


            Console.WriteLine("Sjekker om ulike tur har same tur som a:");
            if (Tur.Sammetur(b, a) == true)
            {
                Console.WriteLine("Samme tur som a");
            }
            else
            {
                Console.WriteLine("Tur forskjellig fra a");  
            }
            if (Tur.Sammetur(f, a) == true)
            {
                Console.WriteLine("Samme tur som a");
            }
            else
            {
                Console.WriteLine("Tur forskjellig fra a");
            }
            if (Tur.Sammetur(a, a) == true)
            {
                Console.WriteLine("Samme tur som a");
            }
            else
            {
                Console.WriteLine("Tur forskjellig fra a");
            }

            Console.WriteLine("             ");
            List<Tur> turliste = new List<Tur>();
            turliste.Add(a);
            turliste.Add(b);
            turliste.Add(c);
            turliste.Add(d);
            turliste.Add(e);
            turliste.Add(f);

            SkrivUt(turliste);

            Console.WriteLine("         ");
            foreach (Tur t in turliste)
            {
                if (t.Lengde > 10)
                {
                    Console.WriteLine(t.ToString());
                }
            }

            Console.WriteLine("         ");
            SortertLengde(turliste);
            SkrivUt(turliste);

            Console.WriteLine("         ");
            turliste.Sort();
            SkrivUt(turliste);

            List<Tur> turliste2 = new List<Tur>();
            turliste2.Add(a);
            turliste2.Add(b);
            turliste2.Add(c);

            Console.WriteLine("\nSortert liste for liste 2: ");
            turliste2.Sort();
            SkrivUt(turliste2);
        }

        static void SkrivUt(List<Tur> turliste)
        {
            foreach (Tur t in turliste)
            {
                Console.WriteLine(t.ToString());
            }
        }

        static void SortertLengde(List<Tur> turliste)
        {
            Console.WriteLine("Tur sortert frå minst til størst:");
            for (int i = 0; i < turliste.Count - 1; i++)
            {
                for (int n = 1; n < turliste.Count - i; n++)
                {
                    if (turliste[n - 1].Lengde > turliste[n].Lengde)
                    {
                        Tur temp = turliste[n];
                        turliste[n] = turliste[n - 1];
                        turliste[n - 1] = temp;
                    }
                }
            }
        }
    }
}
