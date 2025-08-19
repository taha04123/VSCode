using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oppgåve_1
{
    class MilitærFly : Fly
    {
        private string våpenklasse;
        private lokasjon militærflyLokasjon;

        public string Våpenklasse
        {
            get { return våpenklasse; }
            set { våpenklasse = value; }
        }
        public lokasjon MilitærflyLokasjon 
        { 
            get { return militærflyLokasjon; } 
            set { militærflyLokasjon = value; } 
        }

        public MilitærFly(string våpenklasse, lokasjon militærflylokasjon, string typebetegnelse, int produksjonsår)
            :base(typebetegnelse, produksjonsår)
        {
            this.Våpenklasse= våpenklasse;
            this.militærflyLokasjon = militærflylokasjon;
        }

        public void FlyttTil(MilitærFly annetFly)
        {
            Console.WriteLine($"Fly original posisjon: {this.MilitærflyLokasjon}");
            this.MilitærflyLokasjon = annetFly.MilitærflyLokasjon; // Bruker offentlig egenskap
            Console.WriteLine($"Flyttet til samme lokasjon som det andre flyet: {annetFly.MilitærflyLokasjon}");
        }
    }
}
