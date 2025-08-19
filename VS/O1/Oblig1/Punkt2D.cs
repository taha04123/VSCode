using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1
{
    class Punkt2D
    {
        double x;
        double y;

        // Statiske medlemmer for maksX og maksY
        private static double _maksX;
        private static double _maksY;

        // Statiske egenskaper for maksX og maksY med validering
        public static double maksX
        {
            get { return _maksX; }
            set
            {
                if (value < 1)
                    _maksX = 1; // Setter til minst 1 hvis verdien er for liten
                else
                    _maksX = value;
            }
        }

        public static double maksY
        {
            get { return _maksY; }
            set
            {
                if (value < 1)
                    _maksY = 1; // Setter til minst 1 hvis verdien er for liten
                else
                    _maksY = value;
            }
        }

        // Statisk konstruktør som setter standardverdier for maksX og maksY
        static Punkt2D()
        {
            _maksX = 100; // Default verdi for maksX
            _maksY = 100; // Default verdi for maksY
        }

        // Parameterløs konstruktør
        public Punkt2D() : this(0, 0) { }

        // Konstruktør som tar inn x og y verdier
        public Punkt2D(double x, double y)
        {
            X = x; // Setter via tilgangsmedlemmet
            Y = y; // Setter via tilgangsmedlemmet
        }

        // Tilgangsmedlem for x med validering
        public double X
        {
            get { return x; }
            set
            {
                if (value < 0)
                    x = 0; // Setter til 0 hvis verdien er for liten
                else if (value > maksX)
                    x = maksX; // Setter til maksX hvis verdien er for stor
                else
                    x = value;
            }
        }

        // Tilgangsmedlem for y med validering
        public double Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    y = 0; // Setter til 0 hvis verdien er for liten
                else if (value > maksY)
                    y = maksY; // Setter til maksY hvis verdien er for stor
                else
                    y = value;
            }
        }

        public double BeregnAvstandTil(Punkt2D anna)
        {
            return Math.Sqrt(Math.Pow((x - anna.x), 2) + Math.Pow((y - anna.y), 2));
        }

        public string DataSomStreng()
        {
            return $"({x},{y})";
        }

        

        public Punkt2D FinnMellompunkt(Punkt2D anna)
        {
            double mellomX = (x + anna.x) / 2;
            double mellomY = (y + anna.y) / 2;

            return new Punkt2D(mellomX, mellomY);
        }
        public bool LiggerPaaSammeLinjeSom(Punkt2D P1, Punkt2D P2)
        {
            if ((P1.y - P2.y) * (P1.x - x) == (P1.x - y) * (P1.x - P2.x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double AvstandFraOrigo()
        {
            // Pythagoras' setning for å beregne avstanden
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
