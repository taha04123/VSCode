namespace Komplekse_tall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Be brukeren om å oppgi de reelle og imaginære delene for to komplekse tall
            Console.Write("Skriv inn den reelle delen av a: ");
            double realA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv inn den imaginære delen av a: ");
            double imagA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv inn den reelle delen av b: ");
            double realB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv inn den imaginære delen av b: ");
            double imagB = Convert.ToDouble(Console.ReadLine());

            // Opprett to komplekse tall ved hjelp av klassen
            Komplekstall a = new Komplekstall { Real = realA, Imag = imagA };
            Komplekstall b = new Komplekstall { Real = realB, Imag = imagB };

            // Beregn produktet av de to komplekse tallene
            double realProduct = a.Real * b.Real - a.Imag * b.Imag;
            double imagProduct = a.Real * b.Imag + a.Imag * b.Real;

            // Skriv ut resultatet
            Console.WriteLine($"Produktet av de komplekse tallene a og b er: {realProduct} + {imagProduct}i");
        }
    }
}
