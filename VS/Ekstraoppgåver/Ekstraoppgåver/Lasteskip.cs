using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstraoppgåver
{
    class Lasteskip : Skip
    {
        double last;
        double makslast;
        string typelast;
        static Random rand = new Random();

        public Lasteskip(string navn, double vekt, Drivstofftype drivstofftype)
            :base(navn, vekt, drivstofftype)
        {
            this.makslast = 10000;
            this.typelast = "Hamburger";

        }
         public override string ToString()
        {
            return typelast;
        }
        public bool LastGoods(double vekt)
        {
            
            if (last + vekt <= makslast)
            {
                last+=vekt;
                return true;
            }
            else {return false; }
        }
        public bool LostGoods(double vekt)
        {
            
            if (last - vekt >= 0)
            {
                last-=vekt;
                return true;
            }
            else {return false; }
        }


    }
}
