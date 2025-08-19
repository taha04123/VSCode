using System.ComponentModel;

namespace O1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (list.Count <= 10)
            {
                string tekst = Console.ReadLine();
                list.Add(tekst);
            }

            list.Sort();

            Console.WriteLine("\nInnholdet i listen etter alfabetet:");
            ShowAll(list);

            list.Sort(Orden);
            Console.WriteLine("\nInnholdet i listen etter anntall bokstaver:");
            ShowAll(list);
        }
        static int Orden(String x, String y)
        {
            int count1 = 0, count2 = 0;

            foreach (char a in x)
            {
                if (a == 'a')
                    count1++;
            }
            foreach (char a in y)
            {
                if (a == 'a')
                    count2++;
            }
            return (count1 - count2);

        }
       

        static void ShowAll(List<string> list)
        {
            foreach (string tekst in list)
            {
                Console.WriteLine(tekst);
            }
        }
    }
}
