using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgåve_1
{
    enum lokasjon
    {
        Ingen = -1,
        London, //0
        NewYork, //1
        Berlin, //2
        Roma //3


    }
    class PassasjerFly : Fly
    {
        private int passasjertall;
        private int rekkevidde;
        private lokasjon flyLokasjon;

        public int Passasjertall 
        { 
            get { return passasjertall; }
            set
            {
                if (value >= 0)
                {
                    passasjertall = value;
                }
                else
                {
                    throw new ArgumentException("Passasjertall kan ikke være negativt.");
                }
            }
        }
        public int Rekkevidde { get; set; }
        public lokasjon FlyLokasjon { get; set; }

        public PassasjerFly(int passasjertall, int rekkevidde, lokasjon flyLokasjon, string typebetegnelse, int produksjonsår) 
            :base(typebetegnelse, produksjonsår)
        {
            Passasjertall = passasjertall;
            Rekkevidde = rekkevidde;
            FlyLokasjon = flyLokasjon; 
        }
        public void FlyttTil(PassasjerFly annetFly)
        {
            Console.WriteLine($"Fly original posisjon: {this.FlyLokasjon}");
            this.FlyLokasjon = annetFly.FlyLokasjon; // Bruker offentlig egenskap
            Console.WriteLine($"Flyttet til samme lokasjon som det andre flyet: {annetFly.FlyLokasjon}");
        }
    }
}
