using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstraoppgåver
{
    class Posisjon
    {
        double x;
        double y;

        public double X { get => x; set=> x = value; }
        public double Y { get => y; set => y = value; }

        public Posisjon(double X, double Y) 
        { 
            this.X = X;
            this.Y = Y;
        }

        public double BeregnAvstandTil(Posisjon anna)
        {
            return Math.Sqrt(Math.Pow(x - anna.x, 2) + Math.Pow(y - anna.y, 2));
        }
         
        public override string ToString()
        {
            return $"({X},{Y})"; 
        }

    }
}
