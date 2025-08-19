namespace NO2_O3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel r1 = new Rektangel(2,2);
            Rektangel r2 = new Rektangel(3,3);
            Rektangel r3 = new Rektangel(4,4);


            {  //Console.WriteLine("Skriv dimensjon for første rektangel");
               //r1.LesDimensjon();

                //Console.WriteLine("\nSkriv dimensjon for andre rektangel");
                //r2.LesDimensjon();

                //Console.WriteLine("\nSkriv dimensjon for andre rektangel");
                //r3.LesDimensjon();

                //Oppgave 1

                //for (int i = 0; i < 2; i++)
                //{
                //    if (i == 0)
                //    {
                //        Rektangel.farge = ConsoleColor.Red;
                //        Console.WriteLine($"\nRektangel 1:");
                //        r1.tegn('#',ConsoleColor.White);
                //        Console.WriteLine($"\nRektangel 2:");
                //        r2.tegn('#', ConsoleColor.White);
                //        Console.WriteLine($"\nRektangel 3:");
                //        r3.tegn('#', ConsoleColor.White);
                //    }
                //    else 
                //    {
                //       Rektangel.farge = ConsoleColor.Blue;
                //        Console.WriteLine($"\nRektangel 1:");
                //        r1.tegn('*', ConsoleColor.White);
                //        Console.WriteLine($"\nRektangel 2:");
                //        r2.tegn('*', ConsoleColor.White);
                //        Console.WriteLine($"\nRektangel 3:");
                //        r3.tegn('*', ConsoleColor.White);
                //    }
                //}
            }

            //Oppgave 2
            Rektangel.farge = ConsoleColor.Green;
            r1.tegn('*', ConsoleColor.White);
            Console.WriteLine();
            r2.tegn('*', ConsoleColor.White);
            Console.WriteLine();
            r3.tegn();

            Console.WriteLine("\nr1+r2");
            Rektangel r4 = r1+r2;
            r4.tegn();

            Console.WriteLine("\nr3-r1");
            Rektangel r5 = r3-r1;
            r5.tegn();

            Console.WriteLine("\nr1*r2");
            Rektangel r6 = r1*r2;
            r6.tegn();

            Console.WriteLine("\nr1/r2");
            Rektangel r7 = r1/r2;
            r7.tegn();

            if (r1 == r2) Console.Write("Dette VIL IKKE bli vist");
            Rektangel r8 = r1;
            if (r1 == r8) Console.Write("Dette VIL bli vist");

            

        }



    }
}
