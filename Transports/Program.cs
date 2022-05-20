using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargaison[] cargaisons;

            cargaisons = new Cargaison[4];

            cargaisons[0] = new Aerienne("ref1",6000,450000,86000);
            cargaisons[1] = new Aerienne("ref2", 10000, 600000, 49555);
            cargaisons[2] = new Routiere("refR1", 2000, 7400, 58555);
            cargaisons[3] = new Routiere("refR2", 1000, 78800, 35555);


            for (int i=0; i<cargaisons.Length;i++)
            { 
                if (cargaisons[i].calcul() > 480000)
                {
                    cargaisons[i].afficher();
                }
                }

            Console.ReadKey();
        }

    }
}
