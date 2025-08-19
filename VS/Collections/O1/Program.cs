using System.Collections;

namespace O1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("Hei, ");
            a1.Add("kor ");
            a1.Add("kommer ");
            a1.Add("du ");
            a1.Add("frå.");

            // Skriv ut alle elementene i ArrayList på én linje
            foreach (string s in a1)
            {
                Console.Write(s);
            }
            // Legg til en ny linje på slutten etter at alt er skrevet ut
            Console.WriteLine();
            a1.Clear();
            a1.Add(5);
            a1.Add(4);
            a1.Add(3);
            a1.Add(2);
            a1.Add(1);
            int summer = 0;
            foreach (int sum in a1)
            {

                summer += sum;
            }

            Console.WriteLine(summer);
        }
    }
}
