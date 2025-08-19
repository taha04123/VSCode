using static System.Formats.Asn1.AsnWriter;
namespace NO2_02
{
    public class Program
    {
        static void Main(string[] args)
        {

            Thread tA = new Thread(HTA);
            Thread tB = new Thread(HTB);

            tA.Start(); // starter tråden
            tB.Start(); // starter tråden 

            Console.WriteLine("Trykk ein tast for å avslutte ...");
            Console.ReadKey();
        }


        static void HTA()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write('a');
            }

        }

        static void HTB()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write('b');
            }

        }
    }
}

