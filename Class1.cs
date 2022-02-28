using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClass
{

    class matematika
    {
        public double suskaiciuota = 1;
        public double q = 2;//geopmetrines progresijos dauginamasis
        public int k;//kiek kartu reikejo
        public double iki;
        private double temp=0;

        public void uzduotis()
        {
            suskaiciuota = 1;
            q = 2;
            iki = Math.Pow(10, 15);
            for (int i = 2; suskaiciuota < iki; i++)
            {
                temp = suskaiciuota;
                suskaiciuota = suskaiciuota * q;
                q = temp;
                k = i;
            }
        }

    }
}

