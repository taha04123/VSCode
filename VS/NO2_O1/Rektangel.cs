using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO2_O1
{
    internal class Rektangel
    {
        public double Lengde;
        public double Bredde;

        public void LesDimensjon()
        {
            Console.WriteLine("\nSkriv Lengde");
            Lengde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nSkriv Bredde");
            Bredde = Math.Round(Convert.ToDouble(Console.ReadLine()),0);

        }


        public void tegn(char fyll)
        {
            int lengde = (int)Lengde;
            int bredde = (int)Bredde;

            
            for (int i = 0; i < bredde; i++)
            {
                for (int j = 0; j < lengde; j++)
                {
                    Console.Write(fyll);
                }
                Console.WriteLine();
            }
        }

        public int SammenlignMed(Rektangel annetRektangel)
        {
            double arealDette = Lengde * Bredde;
            double arealAnnet = annetRektangel.Lengde * annetRektangel.Bredde;

            if (arealDette > arealAnnet)
            {
                return 1;
            }

            else if (arealDette < arealAnnet)
            {
                return -1;
            }

            else 
            {
                return 0;
            }

        }




    }
}
