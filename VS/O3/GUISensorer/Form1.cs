using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUISensorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface ISensor
        {
            double PosisjonX
            {
                get;
                set;
            }
            double PosisjonY
            {
                get;
                set;
            }
            int Id
            {
                get;
            }
            void Maal();
            string ToString();
        }
        public class Temperaturmaaler : ISensor
        {
            public int Id { get; private set; }
            public double PosisjonX { get; set; }
            public double PosisjonY { get; set; }
            public double Temperatur { get; private set; }

            private Random random = new Random();

            public Temperaturmaaler(int id)
            {
                Id = id;
                Temperatur = 273.15; // Standardverdi for temperatur
            }

            public void Maal()
            {
                // Generer en tilfeldig temperatur mellom 0.0 og 1273.1
                Temperatur = random.NextDouble() * 1273.1;
            }

            public override string ToString()
            {
                return $"{Id}-({PosisjonX},{PosisjonY})"; ;
            }
        }
        public class Trykkmaaler : ISensor
        {
            public int Id { get; private set; }
            public double PosisjonX { get; set; }
            public double PosisjonY { get; set; }
            public double Trykk { get; private set; }

            private Random random = new Random();

            public Trykkmaaler(int id)
            {
                Id = id;
                Trykk = 1.0; // Standardverdi for trykk
            }

            public void Maal()
            {
                // Generer et tilfeldig trykk mellom 0.5 og 2.5
                Trykk = 0.5 + random.NextDouble() * 2.0;
            }

            public override string ToString()
            {
                return $"{Id}-({PosisjonX},{PosisjonY})";
            }
        }


        List<ISensor> sensorList = new List<ISensor>();

        private void NyTemp_btn_Click(object sender, EventArgs e)
        {
            // Generer en ny temperaturmåler med et unikt ID
            int id = sensorList.Count + 1;
            Temperaturmaaler nyTempSensor = new Temperaturmaaler(id);

            // Sett posisjon, eventuelt tilfeldig
            nyTempSensor.PosisjonX = 1;
            nyTempSensor.PosisjonY = id; // Eksempel på posisjonering

            // Legg til sensoren i listen
            sensorList.Add(nyTempSensor);

            // Oppdater GUI-elementer, f.eks. ListBox eller ComboBox
            
            comboBox1.Items.Add(nyTempSensor.ToString());

        }

        private void NyTrykk_btn_Click(object sender, EventArgs e)
        {
            // Generer en ny trykkmåler med et unikt ID
            int id = sensorList.Count + 1;
            Trykkmaaler nyTrykkSensor = new Trykkmaaler(id);

            // Sett posisjon, eventuelt tilfeldig
            nyTrykkSensor.PosisjonX = id; // Eksempel på posisjonering
            nyTrykkSensor.PosisjonY = 1;

            // Legg til sensoren i listen
            sensorList.Add(nyTrykkSensor);

            // Oppdater GUI-elementer
            
            comboBox1.Items.Add(nyTrykkSensor.ToString());
        }

        private void NyMåling_btn_Click(object sender, EventArgs e)
        {
            // Finn den valgte sensoren i ComboBox eller ListBox
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < sensorList.Count)
            {
                // Hent den valgte sensoren
                ISensor valgtSensor = sensorList[selectedIndex];

                // Utfør måling
                valgtSensor.Maal();

                // Skriv måleresultatet til målings-ListBox
                if (valgtSensor is Temperaturmaaler tempSensor)
                {
                    handling_list.Items.Add("Type: Temperaturmåler");
                    handling_list.Items.Add($"Id nummer: {tempSensor.Id}");
                    handling_list.Items.Add($"Siste måling: {tempSensor.Temperatur}");
                }
                else if (valgtSensor is Trykkmaaler trykkSensor)
                {
                    handling_list.Items.Add("Type: Trykkmåler");
                    handling_list.Items.Add($"Id nummer: {trykkSensor.Id}");
                    handling_list.Items.Add($"Siste måling: {trykkSensor.Trykk}");
                }

               
            }
        }

        private void Slett_btn_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
        private void LagreTilFil(string filsti)
        {
            using (StreamWriter writer = new StreamWriter(filsti))
            {
                foreach (ISensor sensor in sensorList)
                {
                    // Skriv ID og posisjonsdata
                    string sensorData = $"{sensor.Id}-({sensor.PosisjonX},{sensor.PosisjonY})";

                    // Hvis du vil lagre siste måling, kan vi også legge til det
                    if (sensor is Temperaturmaaler tempSensor)
                    {
                        sensorData += $", Siste måling: {tempSensor.Temperatur}";
                    }
                    else if (sensor is Trykkmaaler trykkSensor)
                    {
                        sensorData += $", Siste måling: {trykkSensor.Trykk}";
                    }

                    // Skriv sensor-data til filen
                    writer.WriteLine(sensorData);
                }
            }
        }
        private void btnLagre_Click(object sender, EventArgs e)
        {
            // La brukeren velge hvor filen skal lagres
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Kall metoden for å lagre sensordataene til fil
                LagreTilFil(saveFileDialog.FileName);
            }
        }
        private void LesFraFil(string filsti)
        {
            // Fjern alle eksisterende sensorer og tøm GUI-elementene
            sensorList.Clear();
            comboBox1.Items.Clear();
            handling_list.Items.Clear();

            using (StreamReader reader = new StreamReader(filsti))
            {
                string linje;
                while ((linje = reader.ReadLine()) != null)
                {
                    // Kontroller om linjen inneholder nødvendig informasjon for parsing
                    if (linje.Contains("ID") && linje.Contains("Posisjon"))
                    {
                        // Parsing av sensorens ID og posisjon fra linjen
                        string[] deler = linje.Split(',');

                        // Kontroller om det er nok deler i linjen før vi prøver å hente ut data
                        if (deler.Length >= 2)
                        {
                            // Parsing av ID
                            int id = int.Parse(deler[0].Split(':')[1].Trim());

                            // Parsing av posisjonsdata
                            string posisjonString = deler[1].Split(':')[1].Trim();
                            posisjonString = posisjonString.Trim('(', ')'); // Fjern parenteser
                            string[] posisjonDeler = posisjonString.Split(',');

                            if (posisjonDeler.Length == 2)
                            {
                                double posisjonX = double.Parse(posisjonDeler[0].Trim());
                                double posisjonY = double.Parse(posisjonDeler[1].Trim());

                                // Gjenopprett sensor basert på om det er temperatur- eller trykkmåler
                                if (linje.Contains("Temperatur"))
                                {
                                    Temperaturmaaler tempSensor = new Temperaturmaaler(id)
                                    {
                                        PosisjonX = posisjonX,
                                        PosisjonY = posisjonY
                                    };
                                    sensorList.Add(tempSensor);
                                    comboBox1.Items.Add($"{tempSensor.Id}-({tempSensor.PosisjonX},{tempSensor.PosisjonY})");
                                }
                                else if (linje.Contains("Trykk"))
                                {
                                    Trykkmaaler trykkSensor = new Trykkmaaler(id)
                                    {
                                        PosisjonX = posisjonX,
                                        PosisjonY = posisjonY
                                    };
                                    sensorList.Add(trykkSensor);
                                    comboBox1.Items.Add($"{trykkSensor.Id}-({trykkSensor.PosisjonX},{trykkSensor.PosisjonY})");
                                }
                            }
                        }
                    }
                }
            }

        }
        private void btnLesFraFil_Click(object sender, EventArgs e)
        {
            // La brukeren velge en fil å lese fra
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Kall metoden for å lese sensordata fra fil
                LesFraFil(openFileDialog.FileName);
            }
        }
    }
}
