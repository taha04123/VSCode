namespace Ekstraoppgåver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppgave a
            //Posisjon p1 = new Posisjon(4,2);
            //Posisjon p2 = new Posisjon(2,1);

            //Console.WriteLine(p1.BeregnAvstandTil(p2));
            //Console.WriteLine();
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());

            //Oppgave c

            List<Skip> Skipsliste = new List<Skip>(10);
            List<Krigsskip>Krigsskipliste = new List<Krigsskip>(10);

            Random rand = new Random();
            Console.SetWindowSize(120, 60);  // Øker vindusstørrelsen til 120 kolonner og 40 rader
            Console.SetBufferSize(120, 120); // Øker bufferen for å ha 100 rader


            for (int i = 0; i < 10; i++)
            {
                int tall = rand.Next(0, 3);
                Drivstofftype drivstoff = (Drivstofftype)tall;

                if (tall == 0)
                {
                    Skipsliste.Add(new Skip($"H{i}", i * 1000, drivstoff));
                }
                else if (tall == 1)
                {
                    Skipsliste.Add(new Skip($"E{i}", i * 1000, drivstoff));
                }
                else if (tall == 2)
                {
                    Skipsliste.Add(new Skip($"B{i}", i * 1000, drivstoff));
                }


            }
            //Oppgåve 2.
            
            for (int i = 0; i < Skipsliste.Count; i++)
            {
                int posX = Skipsliste[i].PosisjonX;
                int posY = Skipsliste[i].PosisjonY;

                Console.SetCursorPosition(posX, posY);
                Console.Write("*");
            }

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Posisjoner: ");
            for (int i = 0; i < Skipsliste.Count; i++)
            {
                Console.WriteLine(Skipsliste[i].ToString());
            }

            //Oppgåve6
            for (int i = 0; i < Skipsliste.Count; i++)
            {
                // Slett skipet fra den gamle posisjonen
                Console.SetCursorPosition(Skipsliste[i].PosisjonX, Skipsliste[i].PosisjonY);
                Console.Write(" "); // Sletter ved å skrive en tom plass

                // Flytter skipet til ny posisjon
                Skipsliste[i].Flytt(1, 1);

                // Tegner skipet på den nye posisjonen
                int posX = Skipsliste[i].PosisjonX;
                int posY = Skipsliste[i].PosisjonY;

                Console.SetCursorPosition(posX, posY);
                Console.Write("*");

            }

            Console.SetCursorPosition(0, 22 + Skipsliste.Count + 2);
            Console.WriteLine("Posisjoner etter flytt: ");
            for (int i = 0; i < Skipsliste.Count; i++)
            {
                Console.WriteLine(Skipsliste[i].ToString());
            }


            Console.ReadKey();

        }
    }
}
