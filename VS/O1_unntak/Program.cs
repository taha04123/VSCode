namespace O1_unntak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0; double b = 0; double x = 0;

            Console.WriteLine("Oppgi desmaltall a og b:");
            Console.WriteLine();

            try
            {
                Console.Write("\na: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nb: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    throw new ArgumentException("a kan ikkje vere 0");
                }
                x = -b / a;

               
            }
            catch (FormatException)
            {
                Console.WriteLine("Feil: Vennligst skriv inn gyldige desimaltall for både a og b.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Feil: {ex.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Feil: Det oppstod en overflyt eller underflyt med de angitte verdiene.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"En uventet feil oppstod: {ex.Message}");
            }
            finally
            {
                // Skriv ut resultatet
                Console.WriteLine($"Løsningen for ligningen {a}x + {b} = 0 er x = {x}");
            }
        }
    }
}
