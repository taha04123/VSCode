using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO7_O1
{
    class Teller : Måler
    {
        int antall;
        

        static Random r = new Random();
        public Teller(int sensorID, int posX, int posY)
            :base(sensorID, posX, posY)
        {
            Antall = 0;
        }

        public int Antall
        {
            get { return antall; }
            set
            {
                if (value < 0) value = 0;

                else antall = value;
            }
        }
       

        public void Passering()
        {
            Antall++;
        }

        public void Reset()
        {
            Antall = 0;
        }

        public override string ToString()
        {
            return base.ToString() + " tellerverdi: " + this.Antall.ToString();
        }
    }
}
