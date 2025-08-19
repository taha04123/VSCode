namespace N01_O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast inn dimensjoner … rektangler.");
            Console.WriteLine("Programmet skal sammenligne dem.");

            // Oppretter nødvendige variabler
            Rektangel r1 = new Rektangel();
            Rektangel r2 = new Rektangel();

            
            // Leser inn dimensjoner
            Console.Write("R1 - bredde: ");
            r1.Bredde = LesEtTall();
            Console.Write("R1 - lengde: ");
            r1.Lengde = LesEtTall();
            Console.Write("R2 - bredde: ");
            r2.Bredde = LesEtTall();
            Console.Write("R2 - lengde: ");
            r2.Lengde = LesEtTall();
            // Beregner arealer
            double a1 = r1.Bredde * r1.Lengde;
            double a2 = r2.Bredde * r2.Lengde;
            // Sammenligner
            if (a1 < a2) Console.WriteLine("R2 er større!");
            else if (a2 < a1) Console.WriteLine("R1 er større!");
            else Console.WriteLine("Rektangler er like!");
            Console.WriteLine("Trykk en tast for å fortsette ...");
            Console.ReadKey(true);
        }

        static double LesEtTall()
        {
            double svar = 0;
            bool inputOK = false;
            while (inputOK == false) // while(!inputOK)
            {
                try
                {
                    svar = Convert.ToDouble(Console.ReadLine());
                    inputOK = true;
                }
                catch (Exception unntak)
                {
                    Console.WriteLine("Feil! " + unntak.Message);
                }
            }
            return svar;
        }

    }
}
