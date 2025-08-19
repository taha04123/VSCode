namespace Obligatorisk_innlevering_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrering_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNavn.Text))
            {
                MessageBox.Show("Skriv inn navnet ditt");
            }
            else
            {
                //Oppretter ein ny instans av form2
                Form2 form2 = new Form2();

                // Viser Form2
                form2.Show();

                //Skjuler denne formen
                this.Hide();
            }
        }
    }
}
