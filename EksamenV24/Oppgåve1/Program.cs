namespace Oppgåve1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs Kokkekurs = new Kurs();
            Kokkekurs.navn = "Kokkekurs";

            StudieEmne Matematikk = new StudieEmne("Matematikk", 1010, 10, "Vår", 1050);
            StudieEmne Fysikk = new StudieEmne("Fysikk", 1020, 15, "Høst", 1060);
            StudieEmne Elektro = new StudieEmne("Elekro", 1030, 5, "Vår", 1070);
            StudieEmne Programmering = new StudieEmne("Programmering", 1040, 7.5, "Høst", 1080);

            Console.WriteLine("Er matematikk sin studiepoeng større enn fysikk sin studiepoeng: ");
            Console.WriteLine(Matematikk.Studiepoeng >= Fysikk.Studiepoeng);

            List<StudieEmne> list = new List<StudieEmne>();

            list.Add(Matematikk);
            list.Add(Fysikk);
            list.Add(Elektro);
            list.Add(Programmering);

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }


            List<Kurs> list1 = new List<Kurs>();

            list1.Add(Matematikk);
            list1.Add(Fysikk);
            list1.Add(Elektro);
            list1.Add(Kokkekurs);
            list1.Add(Programmering);

            Console.WriteLine();
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] is StudieEmne studieEmne)
                {
                    Console.WriteLine(studieEmne.ToString());
                }

                else if (list1[i] is Kurs kurs)
                {
                    Console.WriteLine(kurs.navn);
                }

            }


        }
    }
}
