using static System.Formats.Asn1.AsnWriter;

namespace NO2_O1
{
    public class Program
    {
        static bool stopp;
        static void Main(string[] args)
        {
            ThreadStart traadFunk = new ThreadStart(BeeperMetode);
            Thread beeperTraad = new Thread(traadFunk);
            beeperTraad.Start(); // starter tråden

            Thread.Sleep(200); // venter 200 ms

            Thread beeperTraad2 = new Thread(traadFunk);
            beeperTraad2.Start(); // starter tråden 2
        }
       

        static public void BeeperMetode()
        {
            while (!stopp)
            {
                Console.Beep(800, 200);
                Console.Beep(1200, 200);
                Console.Beep(1500, 200);
                Thread.Sleep(2000);
            }
        }
    }
}
