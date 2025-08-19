namespace Oblig1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tester klassen Punkt2D:

            Punkt2D P1 = new Punkt2D(1, 4);
            Punkt2D P2 = new Punkt2D(3, 6);

            Console.WriteLine("Avstand mellom {0} og {1} er {2:f4}.",
                P1.DataSomStreng(), P2.DataSomStreng(), P1.BeregnAvstandTil(P2));

            Punkt2D P3 = P1.FinnMellompunkt(P2);
            Console.WriteLine("Mellompunkt for {0} og {1} er {2}.",
                P1.DataSomStreng(), P2.DataSomStreng(), P3.DataSomStreng());

            Punkt2D P4 = P2.FinnMellompunkt(P1);
            Console.WriteLine("Mellompunkt for {0} og {1} er {2}.",
                P2.DataSomStreng(), P1.DataSomStreng(), P4.DataSomStreng());

            if (P3.LiggerPaaSammeLinjeSom(P1, P2)) // det bør P3 gjøre
            {
                Console.WriteLine("Punkt {0}, {1} og {2} ligger på samme linje.",
                   P1.DataSomStreng(), P3.DataSomStreng(), P2.DataSomStreng());
            }

            

            Punkt2D punkt = new Punkt2D(3, 4);
            double avstand = punkt.AvstandFraOrigo();  // Vil returnere 5, siden sqrt(3^2 + 4^2) = 5
            Console.WriteLine($"Avstanden fra origo er: {avstand}");

            Console.WriteLine("\n\n\n");

            
        }
    }
}
