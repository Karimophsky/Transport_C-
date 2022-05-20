using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
   public  class Routiere : Cargaison
    {

        public Routiere(string re, int d, int p, int v) :base(re,d,p,v)
        {

        }
          public   Routiere():base()
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
            if (this.volume < 380000)
            {
                cal = 4 * this.poid * this.distance;

            }
            else if (this.volume >= 380000)
            {
                cal = 6 * this.poid * this.distance;

            }
            return cal;

        }

    }
}
