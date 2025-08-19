using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;

namespace NO15_O2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            int ANTALL = 30000;
            List<int> listMS = new List<int>();

            GenererVerdi(listMS, ANTALL);


            sw.Start();
            listMS = MergeSort(listMS);
            SkrivUt(listMS);
            sw.Stop();

            

            Console.WriteLine("\n");
            Console.WriteLine("Kjøretid (Mergesort): " + sw.Elapsed.ToString());

        }

        static void GenererVerdi(List<int> listMS, int ANTALL)
        {
            for (int i = 0; i < ANTALL; i++)
            {
                Random r = new Random();
                listMS.Add(r.Next(100001));
            }
        }
        

        private static List<int> MergeSort(List<int> lM)
        {
            //returner listen om den har 0 eller 1 element i listen.
            if (lM.Count <= 1) return lM;

            //Finn midten
            int mid = lM.Count / 2; //{1,2,3,4,5,6} / 2 = 3
            List<int> left = lM.GetRange(0,mid);  //{1,2,3}
            List<int> right = lM.GetRange(mid, lM.Count - mid); //{4,5,6}

            //Rekursivt sorter begge halvdelene
            left = MergeSort(left);
            right = MergeSort(right);

            //Flett saman begge halvdelene
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> resultat = new List<int>();
            
            int i = 0; int j = 0;


            //Flett saman listene
            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    resultat.Add(left[i]);
                    i++;
                }
                else
                {
                    resultat.Add(right[j]);
                    j++;
                }

            }

            //Legg til gjenværande frå listen. Sjekker om der er fleire igjen.
            while (i < left.Count)
            {
                resultat.Add(left[i]);
                i++;
            }
            while (j < right.Count)
            { 
                resultat.Add(right[j]);
                j++;
            }

            return resultat;

        }


        static void SkrivUt(List<int> listMS)
        {
            Console.WriteLine("Merge Sort:");
            foreach (int num in listMS)
            {
                Console.Write(num + " ");
            }
        }
    }
}
