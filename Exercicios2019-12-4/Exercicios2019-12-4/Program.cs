using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2019_12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomesCarros = new List<string>()
            {
                "Mustang Eleonor 1976",
                "Opala SS 1985",
                "Dodge Charger 1970",
                "Belina 1990"
            };

            nomesCarros.ForEach(x => Console.WriteLine(x));
            Console.ReadKey(true);

        }
    }
}
