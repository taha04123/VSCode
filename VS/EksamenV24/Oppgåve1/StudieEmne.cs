using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oppgåve1
{
    class StudieEmne : Kurs
    {
        int emneKode;
        double studiepoeng;
        public string semester;
        int høyesteEmneKode;

        public double Studiepoeng {  get { return studiepoeng; } set { studiepoeng = value; } }
        public int EmneKode { get { return emneKode; } }

        public StudieEmne()
            : base()
        {
            string navn = "null";
            int emnekode = 0;
            double studiepoeng = 0;
            string semester = "høst";
        }
        public StudieEmne(string navn, int emnekode, double studiepoeng, string semester, int høyesteEmnekode)
            :base()
        {
            this.navn = navn;
            this.emneKode = emnekode;
            this.studiepoeng = studiepoeng;
            this.semester = semester;
            this.høyesteEmneKode = 1000;
        }

        public override string ToString()
        {
            return $"{navn}, {emneKode}, {studiepoeng}, {semester}";
        }

        public void SkrivUt()
        {
            Console.WriteLine($"Navn: {navn}:");
            Console.WriteLine($"Emnekode: {EmneKode}:");
            Console.WriteLine($"Studiepoeng: {studiepoeng}:");
            Console.WriteLine($"semester: {semester}:");
            Console.WriteLine();
        }

        public void SjekkEmnekode(int høyesteEmnekode)
        {

            if (this.emneKode > this.høyesteEmneKode)
            {
                Console.WriteLine("EmneKode er større enn høyeste eksisterande Emnekode");

            }
            else 
            {
                Console.WriteLine("EmneKode er ikkje større enn høyeste eksisterande Emnekode");
                emneKode = 0;
                semester = "høst";
                navn = "null";
            }
           
        }

        public static bool operator <= (StudieEmne a, StudieEmne b)
        {
            bool svar = false;
            if (a.emneKode <= b.emneKode) return svar = true; 
            return svar;
        }
        public static bool operator >= (StudieEmne a, StudieEmne b)
        {
            bool svar = false;
            if (a.emneKode >= b.emneKode) return svar = true;
            return svar;
        }
    }
}
