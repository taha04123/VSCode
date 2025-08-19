using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O3
{

    class Trykkmaaler: ISensor
    {
        double trykk;
        double posisjonX;
        double posisjonY;
        int id;

        //random
        Random r = new Random();

        public void Maal()
        {  
           double flyttal = 0.5 + r.NextDouble() * 2.0;
           trykk = flyttal;
        }
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
        public Trykkmaaler()
        {
            id = 0;
            posisjonX = 0;
            posisjonY = 0;
        }
        //Konstruktør med argument
        public Trykkmaaler(int ID)
        {
            this.id = ID;
            posisjonX = 0;
            posisjonY = 0;  
        }
        public double Trykk
        {
            get
            {
                return trykk;
            }
        }
        //To-string metoden
        public override string ToString()
        {
            return $"{Id}-({PosisjonX},{PosisjonY})";
        }
    }
}
