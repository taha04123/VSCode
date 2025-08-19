using static System.Formats.Asn1.AsnWriter;
namespace NO2_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Thread tA = new Thread(HT);
            Thread tB = new Thread(HT);

            tA.Start('a'); // starter tråden
            tB.Start('b'); // starter tråden 

            Console.WriteLine("Trykk ein tast for å avslutte ...");
            Console.ReadKey();
        }

        static void HT(object o)
        {
            char tegn = (char)o;

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(tegn);
            }

        }
    }
}

