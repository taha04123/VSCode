namespace NO2_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Komplekstall k1 = new Komplekstall();
            Komplekstall k2 = new Komplekstall();

            Console.WriteLine("K1:");
            k1.Lestall();
            Console.WriteLine("\nK2:");
            k2.Lestall();

            Console.WriteLine();
            Console.WriteLine("Absoluttverdien av dei kompleksetall");
            Console.WriteLine(k1.Abs());
            Console.WriteLine(k2.Abs());

            Console.WriteLine();
            Console.WriteLine("Addisjon av dei kompleksetall");
            Console.WriteLine(k1.LeggTil(k2).UtskriftKartesisk());

            Console.WriteLine();
            Console.WriteLine("Multiplikasjon av dei kompleksetall");
            Console.WriteLine(k1.MultipliserMed(k2).UtskriftKartesisk());

            Console.WriteLine();
            Console.WriteLine("Den kongjugerte av dei kompleksetall");
            Console.WriteLine(k1.LeggTil(k2).Komplekskonjugert());
            Console.WriteLine(k1.MultipliserMed(k2).Komplekskonjugert());

            Console.WriteLine();
            Console.WriteLine("Polarformen til dei kompleksetall");
            Console.WriteLine(k1.UtskriftPolar());
            Console.WriteLine(k2.UtskriftPolar());

        }
    }
}
