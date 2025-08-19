using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBLIG5
{
    public partial class Form2 : Form
    {
        private IBankOperasjon bankOperasjon;
        public Form2(IBankOperasjon bankOperasjon)
        {
            InitializeComponent();
            this.bankOperasjon = bankOperasjon;
            lblSaldo.Text = bankOperasjon.Saldo().ToString("F2");
        }

        private void btnSettInn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBeløp.Text, out double beløp))
            {
                try
                {
                    bankOperasjon.SettInnPenger(beløp);
                    lblSaldo.Text = bankOperasjon.Saldo().ToString("F2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Feil: {ex.Message}", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vennligst skriv inn et gyldig tall!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTaUt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBeløp.Text, out double beløp))
            {
                try
                {
                    if (!bankOperasjon.TaUtPenger(beløp))
                    {
                        MessageBox.Show("Ikke nok saldo!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    lblSaldo.Text = bankOperasjon.Saldo().ToString("F2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Feil: {ex.Message}", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vennligst skriv inn et gyldig tall!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnLoggUt_Click(object sender, EventArgs e)
        {
            bankOperasjon.LoggeUt();
            
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            MessageBox.Show("Du er logget ut", "Melding", MessageBoxButtons.OK);
        }
    }
}
