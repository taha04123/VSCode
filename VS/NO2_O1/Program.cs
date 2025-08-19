namespace NO2_O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel r1 = new Rektangel();
            Rektangel r2 = new Rektangel();


            Console.WriteLine("Skriv dimensjon for første rektangel");
            r1.LesDimensjon();

            Console.WriteLine("\nSkriv dimensjon for andre rektangel");
            r2.LesDimensjon();


            Console.WriteLine("\nRektangel:");
            r1.tegn('#');

            Console.WriteLine("\nRektangel:");
            r2.tegn('*');

            int sammenlignResultat = r1.SammenlignMed(r2);

            // Viser resultatet av sammenligningen
            if (sammenlignResultat < 0)
            {
                Console.WriteLine("\nAndre rektangel har større areal.");
            }
            else if (sammenlignResultat > 0)
            {
                Console.WriteLine("\nFørste rektangel har større areal.");
            }
            else
            {
                Console.WriteLine("\nDe to rektanglene har samme areal.");
            }


        }
    }
}
