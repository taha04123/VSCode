namespace Oppgåve_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fly fly1 = new Fly("123-AB", 1950);
            Fly fly2 = new Fly("123-BC", 1980);

            PassasjerFly passasjerfly1 = new PassasjerFly(200, 400, lokasjon.Roma, "423-AC", 2000);
            PassasjerFly passasjerfly2 = new PassasjerFly(15000, 300, lokasjon.London, "321-AB", 2050);

            MilitærFly militærfly1 = new MilitærFly("A", lokasjon.NewYork, "657-BA", 2050);
            MilitærFly militærfly2 = new MilitærFly("B", lokasjon.Berlin, "555-CB", 2050);

            List<Fly> fly = new List<Fly>();
            fly.Add(fly1);
            fly.Add(fly2);
            fly.Add(passasjerfly1);
            fly.Add(passasjerfly2);
            fly.Add(militærfly1);
            fly.Add(militærfly2);


            Console.WriteLine("Informasjon om fly: ");
            fly1.SkrivUt();
            fly2.SkrivUt();
            passasjerfly1.SkrivUt();
            passasjerfly2.SkrivUt();
            militærfly1.SkrivUt();
            militærfly2.SkrivUt();

            Console.WriteLine("\nSjekker om fly har same typebetegnelse: ");
            bool sammenlign1 = Fly.SammenliknTypeBetegnelse(fly1, fly2);
            bool sammenlign2 = Fly.SammenliknTypeBetegnelse(passasjerfly1, passasjerfly2);
            bool sammenlign3 = Fly.SammenliknTypeBetegnelse(militærfly1, militærfly2);

            Console.WriteLine(sammenlign1);
            Console.WriteLine(sammenlign2);
            Console.WriteLine(sammenlign3);

            Console.WriteLine("\nNo skal vi flytte fly til same lokasjon: ");
            passasjerfly1.FlyttTil(passasjerfly2);
            Console.WriteLine();
            militærfly1.FlyttTil(militærfly2);

            Console.WriteLine("\nInformasjon av fly skrive ut med liste: ");
            for (int i = 0; i < fly.Count; i++)
            {
                if (fly[i] is Fly flyer)
                {
                    flyer.SkrivUt();
                }
                else if (fly[i] is PassasjerFly passasjerFly)
                {
                    passasjerFly.SkrivUt();
                }
                else if (fly[i] is MilitærFly militærFly)
                {
                    militærFly.SkrivUt();
                }
            }

            Console.ReadKey();

        }
    }
}
