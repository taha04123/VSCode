using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O3
{
    class Bil
    {
        private string biltype;
        private string eier;
        private string skilt;

        public string BilType { get { return biltype; } set { biltype = value; } }
        public string Eier { get { return eier; } set { eier = value; } }

        public string Skilt { get { return skilt; } set { skilt = value; } }

        public Bil (string biltype, string eier, string skilt)
        {  
           this.biltype = biltype; 
           this.eier = eier; 
           this.skilt = skilt;
        }

        public void show()
        {
            Console.WriteLine($"{biltype}: {eier}, {skilt}");
        }

    }
}
