using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
   public  class Cargaison
    {
        private readonly int num=0 ;
        private static int cpt=0;

        protected string reference;
        protected int distance;
        protected int poid;
        protected int volume;
        


        public Cargaison() {
            ++cpt;
            this.num = cpt;
            this.reference = "";
            this.distance = 0;
            this.poid = 0;
            this.volume = 0;

        }
        public Cargaison(string re , int d, int p, int v) {

            ++cpt;
            this.num = cpt;
            this.reference = re;
            this.distance = d;
            this.poid = p;
            this.volume = v;
        }

        public  virtual int calcul()
        {
            int i=0;
            return i;
        }

        public void afficher()
        {
            Console.WriteLine("ref :" + this.reference);
            Console.WriteLine("Distance :" + this.distance);
            Console.WriteLine("Poid :" + this.poid);
            Console.WriteLine("Volume :" + this.volume);
           
        }
      
          

    }

}
