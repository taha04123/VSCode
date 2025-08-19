using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgåve1
{
    enum Vanskelighetsgrad
    {
        Lett,
        Middels,
        Krevenede
    }


    class Tur : IComparable<Tur>
    {
        string start;
        string destinasjon;
        double lengde;
        public Vanskelighetsgrad turVanskelighetsgrad;

        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        public string Destinasjon
        {
            get { return destinasjon; }
            set { destinasjon = value; }
        }

        public double Lengde
        {
            get { return lengde; }
            set { lengde = value; }
        }

        public Tur()
        {
            this.start = "ugyldig";
            this.destinasjon = "ugyldig";
            this.lengde = 0;
            this.turVanskelighetsgrad = Vanskelighetsgrad.Lett;
            
        }

        public Tur(string start, string destinasjon, double lengde)
        {
            this.start = start;
            this.destinasjon = destinasjon;
            this.lengde = lengde;
            this.turVanskelighetsgrad = turVanskelighetsgrad;
           
        }

        public override string ToString()
        {
            return $"Tur til:{destinasjon} frå {start}: {lengde} km";
        }

        public static bool Sammetur(Tur a, Tur b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            else if (a.start == b.start && a.destinasjon == b.destinasjon && a.lengde == b.lengde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Tur a, Tur b)
        {
            return a.lengde >= b.lengde;
        }
        public static bool operator <=(Tur a, Tur b)
        {
            return a.lengde <= b.lengde;
        }

        public static Tur operator +(Tur a, Tur b)
        {
            if (a.destinasjon == b.start)
            {
                return new Tur(a.start, b.destinasjon, a.lengde + b.lengde);
            }
            else
            {
                return new Tur("Ugyldig", "Ugyldig", 0);
            }
        }

        public int CompareTo(Tur anna)
        {
            if (anna == null) return 1; // Hvis "other" er null, denne kommer først
            return this.Lengde.CompareTo(anna.Lengde); // Sammenlign lengder
        }
    }
}
