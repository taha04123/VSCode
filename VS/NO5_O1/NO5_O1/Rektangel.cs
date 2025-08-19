using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO5_O1
{
    class Rektangel
    {
        double lengde;
        double bredde;
        public static ConsoleColor farge;

        public double Lengde //tilgangsmedlem
        {
            get { return lengde; }
            set
            {
                if (value > 0) lengde = value;
                else lengde = 0;
            }

        }

        public double Bredde //tilgangsmedlem
        {
            get { return bredde; }
            set
            {
                if (value > 0) bredde = value;
                else bredde = 0;
            }

        }
        public Rektangel(double bredde, double lengde)
        {
            this.bredde = bredde;
            this.lengde = lengde;
        }
        public Rektangel() : this(0, 0)
        {
        }

        public void LesDimensjon() //Leser dimensjoner til rektanglane
        {
            Console.WriteLine("\nSkriv Lengde");
            Lengde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nSkriv Bredde");
            Bredde = Math.Round(Convert.ToDouble(Console.ReadLine()), 0);

        }

        public void tegn() // Inggen argument
        {
            int lengde = (int)Lengde;
            int bredde = (int)Bredde;


            for (int i = 0; i < bredde; i++)
            {
                for (int j = 0; j < lengde; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public void tegn(char fyll, ConsoleColor bakgrunnsfarge) //teinker rektangel med to argumenter
        {
            Console.ForegroundColor = farge;
            Console.BackgroundColor = bakgrunnsfarge;
            int lengde = (int)Lengde;
            int bredde = (int)Bredde;


            for (int i = 0; i < bredde; i++)
            {
                for (int j = 0; j < lengde; j++)
                {
                    Console.Write(fyll);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public double Areal()
        {
            return Math.Round(this.Lengde) * Math.Round(this.Bredde);
        }

        public static Rektangel operator +(Rektangel første, Rektangel andre)
        {
            Rektangel svar = new Rektangel();

            svar.lengde = første.lengde + andre.lengde;
            svar.bredde = første.bredde + andre.bredde;

            return svar;
        }
        public static Rektangel operator -(Rektangel første, Rektangel andre)
        {
            Rektangel svar = new Rektangel();

            svar.lengde = første.lengde - andre.lengde;
            svar.bredde = første.bredde - andre.bredde;

            return svar;
        }
        public static Rektangel operator *(Rektangel første, Rektangel andre)
        {
            Rektangel svar = new Rektangel();

            svar.lengde = første.lengde * andre.lengde;
            svar.bredde = første.bredde * andre.bredde;

            return svar;
        }
        public static Rektangel operator /(Rektangel første, Rektangel andre)
        {
            Rektangel svar = new Rektangel();

            svar.lengde = Math.Round(første.lengde / andre.lengde);
            svar.bredde = Math.Round(første.bredde / andre.bredde);

            return svar;
        }
        public static bool operator ==(Rektangel første, Rektangel andre)
        {
            bool svar = false;
            if (første.Lengde == andre.Lengde && første.Bredde == andre.Bredde) svar = true;
            return svar;
        }
        public static bool operator !=(Rektangel første, Rektangel andre)
        {
            return !(første == andre); // bruker == for to Rektangel-objekter
        }
    }
}
