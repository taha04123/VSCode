using System.Diagnostics.CodeAnalysis;

namespace NO5_O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] itab = new int[10];
            //Random r = new Random();

            //int sum = 0;
            //for (int i = 0; i < itab.Length; i++)
            //{

            //    itab[i] = r.Next(0,99);
            //    sum += itab[i];
            //    Console.WriteLine($"Heiltall {i+1}: {itab[i]}");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Summen av 10 tilfeldige heiltall: {sum}");

            Rektangel[] tab = new Rektangel[10];
            Random r = new Random();
            double sum = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                double lengde = r.Next(1, 10);
                double bredde = r.Next(1, 10);
                tab[i] = new Rektangel(lengde, bredde);
                sum += tab[i].Areal();
                Console.WriteLine($"Rektangel areal {i + 1}: {tab[i].Areal()}");
            }
            Console.WriteLine($"\nSummen av areal: {sum}\n");


            List<Rektangel> rlist = new List<Rektangel>();

            double sumliste = 0;
            for (int i = 0; i <= 10; i++)
            {
                double lengde = r.Next(1, 10);
                double bredde = r.Next(1, 10);
                rlist.Add(new Rektangel(lengde, bredde));
                sumliste += rlist[i].Areal();
                Console.WriteLine($"Rektangel areal {i + 1}: {rlist[i].Areal()}");
            }
            Console.WriteLine($"\nSummen av areal: {sumliste}");
        }

        

        
        
    }
}
