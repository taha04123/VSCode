using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBLIG5
{
    public interface IBankOperasjon
    {
        bool Autentifisere(String bruker);
        void LoggeUt();
        void SettInnPenger(double beløp);
        bool TaUtPenger(double beløp);
        double Saldo();
    }
}
