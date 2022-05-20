using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    public class Aerienne : Cargaison
    {

        public Aerienne(string re, int d, int p, int v) : base(re, d, p, v)
        {

        }
       public  Aerienne() : base()
        {

        }
        public void afficher()
        {
            base.afficher();
            Console.WriteLine("cout :"+this.calcul());
        }
        public override int calcul()
        {
            int cal = 0;
            if (this.volume < 80000)
            {
                cal = 10 * this.poid * this.distance;

            }

            else if (this.volume >= 80000)
            {
                cal = 20 * this.poid * this.distance;

            }
            return cal;
        }
    }
}
