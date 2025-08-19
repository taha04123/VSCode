using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstraoppgåver
{
    class Krigsskip : Skip
    {
        int antallKanoner;
        double kanonrekkevidde;
        bool antiUbot;

        static Random rand = new Random();

        public Krigsskip(string navn, double vekt, Drivstofftype drivstofftype)
            : base(navn, vekt, drivstofftype)
        {
            this.kanonrekkevidde = 1000;
            this.antiUbot = false;
            this.antallKanoner = 3;
        }

        public bool Fyrkanon(Skip mål)
        {
            double avstand = this.AvstandTil(mål);
            if (avstand <= kanonrekkevidde)
            {
                // Simulerer en 10 % sjanse til å treffe målet
                int tilfeldigtall = rand.Next(1, 101); // Genererer et tall mellom 1 og 100
                if (tilfeldigtall <= 10) // 10 % sjanse for treff
                {
                    antiUbot = true; // Treffer målet
                    Console.WriteLine($"{this.ToString()} skyter på {mål.ToString()}. Resultat: treff");
                }
                else
                {
                    antiUbot = false; // Bommer
                    Console.WriteLine($"{this.ToString()} skyter på {mål.ToString()}. Resultat: bom");
                }
            }
            else
            {
                // Skipet er utenfor rekkevidde
                Console.WriteLine($"{this.ToString()} kan ikke skyte på {mål.ToString()}. Mål er utenfor rekkevidde.");
                antiUbot = false;
            }
            return antiUbot;

        }
    }
}
