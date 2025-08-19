using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO7_O1
{
    class Temperaturmåler : Måler
    {
        double temperatur;
        
        static Random r = new Random();

        public Temperaturmåler(int sensorID, int posX, int posY) 
         :base (sensorID,posX,posY)
        {
            temperatur = 273.15;
        }
        
        public double Temperatur 
        {
            get { return temperatur; }
            set 
            { 
                if(value < 0) value = 0;

                else temperatur = value; 
            }
        }
        public Temperaturmåler(): this(0,0,0)
        { }

        public void Mål()
        {
            temperatur = r.Next(250, 300);
        }

        public override string ToString()
        {
            return base.ToString() + " måleverdi: " + Temperatur.ToString();
        }
        

    }
}
