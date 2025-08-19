namespace NO14_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv eit heiltall for å rekne ut fakultet: ");

            int n = 0;
            //int fakultet = 1;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0) throw new ArgumentOutOfRangeException("n", "Tallet må vere positiv");
            }
            catch (FormatException)
            {
                Console.WriteLine("Feil: Du må skrive inn eit heiltall.");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Feil: Tallet er for stort.");
                return;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Feil: " + e.Message);
                return;
            }
            finally 
            {
                //ikkje rekursiv løsning

                //for (int i = 1; i <= n; i++)
                //{
                //    fakultet *= i;
                //}
                //Console.WriteLine($"{n}!= {fakultet}");

                //rekursiv løsning
            }
            long fakultet(int n)
            {
                if (n == 0) return 1;
                else return n * fakultet(n - 1);
            }

            long resultat = fakultet(n);
            Console.WriteLine(resultat);

            
        }
    }
}
