using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgåve2
{
    class Hund
    {
        string navn;
        string eier;
        static string konkurransetype;
        double poengsum;

        public double Poengsum 
        { 
            get {return poengsum;}
            set 
            {
                if (value >= 0 && value <= 10)
                {
                    poengsum = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Poengsum må være mellom 0 og 10.");
                }
            }
        }

        public Hund()
        {
            this.navn = string.Empty;
            this.eier = string.Empty;
            poengsum = 0;
        }
        public Hund(string navn, string eier)
        {
            this.navn = navn;
            this.eier = eier;
            poengsum = 0;
        }

        public void RegistrerPoeng(int poeng1, int poeng2, int poeng3)
        {
            int totalpoeng = poeng1 + poeng2 + poeng3;
            if (totalpoeng + poengsum > 10)
            {
                throw new InvalidOperationException("Totalt poengsum kan ikke overstige 10.");
            }
            poengsum += totalpoeng;
        }

        public override string ToString()
        {
            return $"Navn: {navn}, Poengsum: {poengsum}";
        }

        public static int Sammenlignpoeng(Hund hund1, Hund hund2)
        {
            return hund2.poengsum.CompareTo(hund1.poengsum);
        }

        public static int Sammenlignnavn(Hund hund1, Hund hund2)
        {
            return string.Compare(hund1.navn, hund2.navn);
        }

        public static void SettKonkurransetype(string type)
        {
            konkurransetype = type;
        }
        public static string HentKonkurransetype()
        {
            return konkurransetype;
        }
    }
}
