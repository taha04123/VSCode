using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O3
{
    interface ISensor
    {
        double PosisjonX
        {
            get;
            set;
        }
        double PosisjonY
        {
            get;
            set;
        }
        int Id
        {
            get;
        }
        void Maal();
        string ToString();
    }

    class Temperaturmåler: ISensor
    {
        //datamedlemmer
        double posisjonX;
        double posisjonY;
        double temperatur;
        int id;

        //random
        Random r = new Random();

        //Tilgangsmedlemmer
        public double PosisjonX
        {
            get { return posisjonX; }
            set
            {
                if (posisjonX >= -180 && posisjonX <= 179)
                {
                    posisjonX = value;
                }
            }
        }
        public double PosisjonY
        {
            get { return posisjonY; }
            set
            {
                if (posisjonY >= -90 && posisjonY <= 90)
                {
                    posisjonY = value;
                }
            }
        }
        public int Id 
        {
            get { return id; }
        }
        //Standardkonstruktør
        public Temperaturmåler()
        {
            temperatur = 273.15;
            id = 0;
            posisjonX = 0;
            posisjonY = 0;
        }
        //Konstruktør med argument
        public Temperaturmåler(int ID)
        {
            this.id = ID;
            posisjonX = 0 ; 
            posisjonY = 0 ;
            temperatur = 273.15;
        }
        //get-property for temperatur
        public double Temperatur
        {
            get
            {
                return temperatur;
            }
        }
        //To-string metoden
        public override string ToString()
        {
            return $"{Id}-({PosisjonX},{PosisjonY})";
        }
        public void Maal()
        {
            double flyttal = r.NextDouble() * 1273.1;
            temperatur = flyttal;
        }
    }
}
