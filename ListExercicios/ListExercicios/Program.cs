using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaCarros = new List<string>()
            {
                "Celta",
                "Corsa",
                "Sandero",
                "Tempra",
                "Focus"
            };
            listaCarros.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
            
        }
    }
}
