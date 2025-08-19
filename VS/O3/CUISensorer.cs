namespace O3
{
    class CUISensorer
    {
        static void Main(string[] args)
        {
            List<ISensor> sensorl = new List<ISensor>(10);

            for (int i = 1; i <= 5; i++)
            {
                    sensorl.Add(new Temperaturmåler(i));
                    sensorl[sensorl.Count - 1].PosisjonX = 1;
                    sensorl[sensorl.Count - 1].PosisjonY = i;
            }

            int[] trykkPosX = { 1, 3, 5, 7, 9 }; // PosisjonX verdier for trykkmålerne
            for (int j = 0; j < 5; j++)
            {
                sensorl.Add(new Trykkmaaler(j+6));
                sensorl[sensorl.Count - 1].PosisjonX = trykkPosX[j];
                sensorl[sensorl.Count - 1].PosisjonY = 1;
            }

            Console.WriteLine();
            foreach(ISensor sensor in sensorl)
            {
                sensor.Maal();

                // Sjekker om sensoren er en Temperaturmaaler
                if (sensor is Temperaturmåler temperaturSensor)
                {
                    Console.WriteLine("\nTemperaturmålinger:");
                    // Skriv ut ID og resultatet av målingen (temperatur)
                    Console.WriteLine($"ID: {temperaturSensor.Id}, Resultat av måling: {temperaturSensor.Temperatur}");
                }

                // Sjekker om sensoren er en Trykkmaaler
                else if (sensor is Trykkmaaler trykkSensor)
                {
                    Console.WriteLine("\nTrykkmålinger:");
                    // Skriv ut ID og resultatet av målingen (trykk)
                    Console.WriteLine($"ID: {trykkSensor.Id}, Resultat av måling: {trykkSensor.Trykk}");
                }
                Console.WriteLine(sensor.ToString());
            }
        }
    }
}
