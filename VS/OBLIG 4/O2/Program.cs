namespace O2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int Antall = 100000;

            GenererVerdi(list, Antall);
            Absolutt(list);
            Console.WriteLine(FinnDistinkte(list));


        }
        
        static void GenererVerdi(List<int> list, int Antall)
        {
            Random r = new Random();
            for (int i = 0; i <= Antall; i++)
            {

                list.Add(Convert.ToInt32(r.Next(-100001, 100001)));
            }
        }

        static void Absolutt(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = Math.Abs(list[i]);  
            }
        }

        static int FinnDistinkte(List<int> list)
        {
            HashSet<int> distinkteTall = new HashSet<int>(list);
            return distinkteTall.Count;
        }
        
    }

   
}
