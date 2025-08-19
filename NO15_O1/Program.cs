using System.Reflection.Emit;

namespace NO15_O1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ANTALL = 100000;
            List<int> listBS = new List<int>();
            


            GenererVerdi(listBS, ANTALL);
            BubbleSort(listBS);
            SkrivUt(listBS);

            Console.ReadKey(true);
        }





        static void GenererVerdi(List<int> listBS, int ANTALL)
        {
            Random r = new Random();
            for (int i = 0; i < ANTALL; i++)
            {
                listBS.Add(r.Next(100001));
            }
        }

        static void BubbleSort(List<int> lBS)
        {
            //Bestemmer antall 
            for (int i = 0; i < lBS.Count; i++)
            {
                //Dette er sjølve byttingen.
                for (int n = 1; n < lBS.Count - i; n++)
                {
                    if (lBS[n-1] > lBS[n])
                    {
                        int temp = lBS[n];
                        lBS[n] = lBS[n - 1];
                        lBS[n - 1] = temp;
                    }
                }

            }
        }

        static void SkrivUt(List<int> listBS)
        {
            Console.WriteLine("Bobble sort:");
            foreach (int num in listBS)
            {
                Console.Write(num + " ");
            }
        }

    }
}
