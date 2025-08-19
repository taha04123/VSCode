namespace NO7_O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperaturmåler temp1 = new Temperaturmåler(0, 0, 0);
            Teller teller1 = new Teller(1, 1, 1);
            Teller teller2 = new Teller(2, 2, 2);
            Måler m1 = new Måler(3, 3, 3);
            Temperaturmåler temp2 = new Temperaturmåler(4, 4, 4);

            //Legger til alle målinger i ein liste
            List<Måler> tList = new List<Måler>();
            tList.Add(temp1);
            tList.Add(teller1);
            tList.Add(teller2);
            tList.Add(m1);
            tList.Add(temp2);

            Console.WriteLine("Utfører målinger...");

            foreach (Måler enMåler in tList)
            {
                if (enMåler is Temperaturmåler)
                {
                    Temperaturmåler t = enMåler as Temperaturmåler;
                    t.Mål();
                }
                else if (enMåler is Teller)
                {
                    (enMåler as Teller).Passering();
                }
            }

            Console.WriteLine("\nSkriver ut måleverdier ...");
            foreach (Måler enMåler in tList)
            {
                Console.WriteLine(enMåler.ToString());
            }

            // Oppgave 5
            Console.WriteLine("Oppgave 5 ... ");

            Random r = new Random();
            tList.Clear();
            int tall;

            for (int i = 0; i < 10; i++)
            {
                tall = r.Next(0, 2);
                if (tall == 0)
                {
                    tList.Add(new Temperaturmåler(i, i, i));
                }
                else
                {
                    tList.Add(new Teller(i, i, i));
                }
            }
            for (int i = 0; i < tList.Count; i++)
            {
                if (tList[i] is Temperaturmåler)
                {
                    (tList[i] as Temperaturmåler).Mål();
                }
                else
                {
                    tall = r.Next(0, 10);
                    for (int j = 0; j < tall; j++)
                    {
                        (tList[i] as Teller).Passering();
                    }
                }
            }
            for (int i = 0; i < tList.Count; i++)
            {
                Console.WriteLine(tList[i].ToString());
            }
        }
    }
}
