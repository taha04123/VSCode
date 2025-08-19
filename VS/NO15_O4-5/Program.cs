namespace NO15_O4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {




            for (int i = 0; i < n; i++) // Ytterste løkke går n ganger
            {
                for (int j = 0; j < z; i++) // Midterste løkke går z ganger
                {
                    for (int k = 0; k < 10; i++) // Innerste løkke går 10 ganger
                    {
                        jobZ;
                    }
                }
            }

            //Totale iterasjoner er: Totale tidsenheter = n*z*10, når jobz tar 1 tidsenhet

            for (int i = 0; i < n; i++) // Første og ytterste løkke går n ganger
            {
                for (int j = 0; j < n; i++) //Første og innerste løkken går n ganger
                {
                    jobZ; //x
                }
            }
            // Totalt hittil = n*n*x = (n^2)*x

            jobZ; //x

            // Totalt hittil = (n^2)*x + x

            for (int i = 0; i < n; i++) // Siste løkke går n ganger
            {
                jobZ; // x
            }

            //Totale iterasjoner er: Totale tidsenheter = (n^2)*x + x + n*x = x(n^2 + 1 + n)


            //O6

            //3n^4 + 1, O(n^2)
            //8n + 4n^2 + 4, O(n^2)
            //3n + 2n, O(n)
            //4n + 3n^2 + 2n^3 + n^4 , O(n^4)
            //5, O(1)

            //O7
            //A1 = 100*n^2 + 40*n
            //A2 = n^3 - 1000

            //A = O(n^2) + O(n^3) = O(n^3)

            //O8
            //O(n) + O(n^2) = O(n^2)
            //O(log n) + O(n) = O(n)
            //O(n^100) + O(2^n) = O(2^n)
            //O(log n) + O(n^2) + O(n*log n) = O(n^2)
            //O(1) + O(1) = O(1)

        }
    }
}
