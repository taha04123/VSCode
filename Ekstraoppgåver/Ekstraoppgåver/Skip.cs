using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstraoppgåver
{
    enum Drivstofftype
    {
        Hydrogen,
        Elektrisk,
        Olje
    }
    class Skip
    {
        string navn;
        protected double vekt;
        static Random r = new Random();

        protected Drivstofftype drivstofftype;

        int posisjonX;
        int posisjonY;

        public int PosisjonX 
        {
            get 
            {
                return posisjonX;
            }
            set 
            {
                if (posisjonX >= 0 && posisjonX <= 80)
                {
                    posisjonX = value;
                }
            }
        }
        public int PosisjonY
        {
            get
            {
                return posisjonY;
            }
            set
            {
                if (posisjonY >= 0 && posisjonY<=20)
                {
                    posisjonY = value;
                }
            }
        }

        public Skip(string navn, double vekt, Drivstofftype drivstofftype)
        {
            this.navn = navn;
            this.vekt = vekt;
            this.drivstofftype = drivstofftype;

            posisjonX = r.Next(0,81); 
            posisjonY = r.Next(0,21);

        }
        
       

        public override string ToString()
        {
            return $" Navn: {navn} - Vekt: {vekt} - Drifstoff: {drivstofftype} - Posisjon: ({posisjonX},{posisjonY})";
        }
        public double AvstandTil(Skip annetskip)
        {
            return Math.Sqrt(Math.Pow(posisjonX-annetskip.posisjonX,2)+ Math.Pow(posisjonY - annetskip.posisjonY, 2));
        }
        public void Flytt(double deltax, double deltay)
        {
            posisjonX += (int)deltax;
            posisjonY += (int)deltay;

            // Passer på at posisjonene ikke går utenfor grensene [0,80] for x og [0,20] for y
            if (posisjonX > 80) posisjonX = 80;
            if (posisjonY > 20) posisjonY = 20;
            if (posisjonX < 0) posisjonX = 0;
            if (posisjonY < 0) posisjonY = 0;

           
        }

        
    }
}
