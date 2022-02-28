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

            matieka obj = new matieka(5);//paduodam faktorialo skaiciu
            obj.uzduotis();
            obj.write();

            end = DateTime.Now;
            TimeSpan laikas = (end - start);

            Console.WriteLine("\nUžtruko: " + laikas.TotalMilliseconds + "ms");
            Console.ReadLine();
        }
    }
}
