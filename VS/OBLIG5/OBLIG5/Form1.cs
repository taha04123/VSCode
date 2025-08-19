namespace OBLIG5
{
    
    public partial class Form1 : Form 
    {
        private IBankOperasjon bankOperasjon;
        public Form1()
        {
            InitializeComponent();
            bankOperasjon = new BankOperasjon();
        }

        private void btnLoggPå_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            if (string.IsNullOrWhiteSpace(txtNavn.Text))
            {
                MessageBox.Show("Vennligst skriv inn et navn!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (bankOperasjon.Autentifisere(navn))
                {
                    Form2 form2 = new Form2(bankOperasjon);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Autentifisering mislykkes", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
