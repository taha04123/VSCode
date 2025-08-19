using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO2_4_6
{
    internal class Komplekstall
    {
        double real;  // Reell del av komplekse tallet
        double imag;  // Imaginær del av komplekse tallet
 

        public double Real //Tilgangsmedlem
        {
            get { return real; }
            set { real = value; }
        }

        public double Imag //Tilgangsmedlem
        {
            get { return imag; }
            set { imag = value; }
        }

        public Komplekstall() // Kontruktør uten argument
        {
            real = 0;
            imag = 0;
        }

        public Komplekstall(double iR, double iI) //Konstruktør med argument
        {
            real = iR;
            imag = iI;
        }

        public void Lestall()
        {
            Console.WriteLine("\nReal");
            Real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Imag");
            Imag = Convert.ToDouble(Console.ReadLine());
        }



        public double Abs()
        {
            return Math.Sqrt(Math.Pow(Real,2)+Math.Pow(Imag,2));
        }

        public Komplekstall LeggTil(Komplekstall detAndre)
        { 
            Komplekstall svar = new Komplekstall();
            svar.Real = Real + detAndre.Real;
            svar.Imag = Imag + detAndre.Imag;
            return svar;
        }

        public Komplekstall MultipliserMed(Komplekstall detAndre)
        {
            Komplekstall svar = new Komplekstall();
            svar.Real = Real * detAndre.Real - Imag * detAndre.Imag;
            svar.Imag = Real * detAndre.Imag + Imag * detAndre.Real;
            return svar;
        }


        // Overskriver ToString for å skrive ut komplekstallene i formatet "a + bi"
        public string UtskriftKartesisk()
        {
            if (Imag >= 0)
            {
                return $"{Real} + {Imag}i";
            }
            else
            {
                return $"{Real} - {Math.Abs(Imag)}i";
            }
        }

        public string Komplekskonjugert()
        {
            if (Imag >= 0)
            {
                return $"{Real} - {Imag}i";
            }
            else
            {
                return $"{Real} + {Math.Abs(Imag)}i";
            }
        }

        public string UtskriftPolar()
        {
            if (real > 0)
            {
                double r = Math.Round(Abs(), 2);
                double theta = Math.Round(Math.Atan2(Imag, Real), 2);
                return $"{r}(cos{theta} + isin{theta})";
            }
            else if ((real < 0) && (imag >= 0))
            {
                double r = Math.Round(Abs(), 2);
                double theta = Math.Round(Math.Atan2(Imag, Real) + Math.PI, 2);
                return $"{r}(cos{theta} + isin{theta})";
            }
            else if ((real < 0) && (imag < 0))
            {
                double r = Math.Round(Abs(), 2);
                double theta = Math.Round(Math.Atan2(Imag, Real) - Math.PI, 2);
                return $"{r}(cos{theta} + isin{theta})";
            }
            else if ((real == 0) && (imag > 0))
            {
                double r = Math.Round(Abs(), 2);
                double theta = Math.Round(Math.PI / 2.0, 2);
                return $"{r}(cos{theta} + isin{theta})";
            }
            else if ((real == 0) && (imag < 0))
            {
                double r = Math.Round(Abs(), 2);
                double theta = Math.Round(-(Math.PI / 2.0), 2);
                return $"{r}(cos{theta} + isin{theta})";
            }
            else if ((real == 0) && (imag == 0))
            {
                return "Udefinert";
            }
            else
            {
                return "Ukjent tilstand";
            }
        }


    }
}
