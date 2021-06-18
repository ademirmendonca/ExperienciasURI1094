using System;
using System.Globalization;

namespace ExperienciasURI1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalCobaias = 0, totalCoelhos = 0, totalSapos = 0, totalRatos = 0;      


            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int cobaia = int.Parse(vet[0]);
                string animal = (vet[1]);

                totalCobaias = totalCobaias + cobaia;
                if (animal == "c" || animal == "C")
                {
                    totalCoelhos = totalCoelhos + cobaia;
                }

                else if (animal == "s" || animal == "S")
                {
                    totalSapos = totalSapos + cobaia;
                }

                else if (animal == "r" || animal == "R")
                {
                    totalRatos = totalRatos + cobaia;
                }
            }

            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalCoelhos);
            Console.WriteLine("Total de ratos: " + totalRatos);
            Console.WriteLine("Total de sapos: " + totalSapos);

            double percentualCoelhos = (double)totalCoelhos * 100 / totalCobaias; 
            Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture) + (" %"));

            double percentualRatos = (double) totalRatos * 100 / totalCobaias;
            Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2", CultureInfo.InvariantCulture) + (" %"));

            double percentualSapos = (double) totalSapos * 100 / totalCobaias;
            Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2", CultureInfo.InvariantCulture) + (" %"));

        }
    }
}
