using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBLIG5
{
    public class BankOperasjon : IBankOperasjon
    {
        private bool erAutentifisert = false;
        private double saldo = 300.0;

        public bool Autentifisere(String bruker)
        {
            if (bruker == "Admin")
            {
                erAutentifisert = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void LoggeUt()
        {
            erAutentifisert = false;
        }
        public void SettInnPenger(double beløp)
        {
            if (!erAutentifisert)
            {
                throw new InvalidOperationException("Ikke autentisert.");
            }
            if (beløp <= 0.0)
            {
                throw new ArgumentException("Beløpet må være positivt.");
            }
            saldo += beløp;
        }
        public bool TaUtPenger(double beløp)
        {
            if (!erAutentifisert)
            {
                throw new InvalidOperationException("Ikke autentisert.");
            }
            if (beløp <= 0.0)
            {
                throw new ArgumentException("Beløpet må være positivt.");
            }
            if (saldo < beløp)
                return false;
            saldo -= beløp;
            return true;    
        }
        public double Saldo()
        {
            if (!erAutentifisert)
            {
                throw new InvalidOperationException("Ikke autentisert.");
            }
            return saldo;
        }
    }
}
