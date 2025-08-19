using System.Reflection;

namespace Oppgåve2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund.SettKonkurransetype("Hopp");

            Hund hund1 = new Hund("Bella", "Ola Nordmann");
            Hund hund2 = new Hund("Max", "Kari Nordmann");
            Hund hund3 = new Hund("Charlie", "Peder Ås");

            List<Hund> liste = new List<Hund> { hund1, hund2, hund3};

            try
            {
                hund1.RegistrerPoeng(1, 2, 3); 
                hund2.RegistrerPoeng(1, 4, 0);
                hund3.RegistrerPoeng(4, 5, 1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Feil: {ex.Message}");
            }

            Console.WriteLine("Sortert poengsum: ");
            liste.Sort(Hund.Sammenlignpoeng);
            SkrivUtListe(liste);
            

            Console.WriteLine("\nSortert navn: ");
            liste.Sort(Hund.Sammenlignnavn);
            SkrivUtListe(liste);
        }
        static void SkrivUtListe(List<Hund> liste)
        {
            foreach (var hund in liste)
            {
                Console.WriteLine(hund.ToString());
            }
        }
    }
}
