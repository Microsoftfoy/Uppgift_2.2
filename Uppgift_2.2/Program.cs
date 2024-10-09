using System;
namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt har Alma och Elin hoppat? (i meter)");
            Console.WriteLine("Alma:");
            string Alma = Console.ReadLine();
            Console.WriteLine("Alma har hoppat så har långt" + " " + Alma);
            Console.WriteLine("Elin");
            string Elin = Console.ReadLine();
            Console.WriteLine("Elin har hoppat så här långt" + " " + Elin);

            Double Alma1 = Double.Parse(Alma);
            Double Elin1 = Double.Parse(Elin);
            Elin1 = Elin1 - Alma1;

            Console.WriteLine("Elin har hoppat" + Elin1 + " " + "mer än Alma");

            Console.ReadKey();
        }
    }
}