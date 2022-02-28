// See https://aka.ms/new-console-template for more information
using System;
namespace ExClass 
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start;//kodo vykdymo pradžia
            start = DateTime.Now;

            DateTime end; //kodo vykdymo pabaiga

            matematika obj = new matematika();
            obj.uzduotis();

            end = DateTime.Now;

            TimeSpan laikas = (end - start);

            Console.WriteLine("Galutinis skaicius: " + obj.suskaiciuota + "\nPrireikė kartų: " + obj.k + "\nUžtruko: " + laikas.TotalMilliseconds + " ms");
            Console.ReadLine();
        }
    }
}
