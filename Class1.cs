using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClass
{

    class matematika
    {
        public double skaiciuojama;
        public double q;//sekos antras skaicius
        public int k;//kiek kartu reikejo
        public double iki;
        private double temp=0;

        public void uzduotis()
        {
            skaiciuojama = 1;
            q = 2;
            iki = Math.Pow(10, 15);
            for (int i = 2; skaiciuojama < iki; i++)
            {
                temp = skaiciuojama;
                skaiciuojama = skaiciuojama * q;
                q = temp;
                k = i;
            }
        }
    }

    class matieka : matematika 
    {
        public int fskaicius;
        public int fatsakymas=1;

        public matieka(int FaktorialoSkaicius) 
        {
            fskaicius = FaktorialoSkaicius;
            while (fskaicius > 0) 
            {
                fatsakymas = fatsakymas * fskaicius;
                fskaicius--;
            }
        
        }

        public void write() 
        {
            Console.WriteLine("Sekos galutinis skaicius: " + skaiciuojama + "\nPrireikė kartų: " + k + "\n\nFaktorialas: " + fatsakymas);
        }
    
    
    }
}

