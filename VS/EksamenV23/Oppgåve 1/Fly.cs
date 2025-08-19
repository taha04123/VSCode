using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgåve_1
{
    class Fly
    {
        private string typebetegnelse;
        private int produksjonsår;

        public int Produksjonsår 
        { get {  return produksjonsår;   } 
            set 
            {
                if (produksjonsår < 1900)
                {
                    produksjonsår = 1900;
                }
                else if (produksjonsår > 2050)
                {
                    produksjonsår = 2050;
                }
                else
                {
                    produksjonsår = value;
                }
            } 
        }
        public string Typebetegnelse { get {return typebetegnelse;} set { typebetegnelse = value; } }


        public Fly() 
        {
            this.typebetegnelse = string.Empty;
            this.produksjonsår = 0;
        }

        public Fly(string typebetegnelse, int produksjonsår)
        {
            Typebetegnelse = typebetegnelse;
            Produksjonsår = produksjonsår;
        }

        public void SkrivUt()
        {
            Console.WriteLine($"Typebetegnelse: {typebetegnelse}");
            Console.WriteLine($"Produksjonsår: {produksjonsår}");
        }

        public override string ToString()
        {
            return $"{typebetegnelse} {produksjonsår}";
        }
        public static bool SammenliknTypeBetegnelse(Fly lokasjon1, Fly lokasjon2)
        {
            return lokasjon1.typebetegnelse == lokasjon2.typebetegnelse;
        
        }
    }
}
