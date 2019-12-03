using System;
using System.Collections.Generic;

namespace MeuProjGit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaLista = new List<string>
            {
                "Felipe",
                "Gilmar",
                "Ariosvaldo",
                "Adagoberto",
                "Valdisney",
                "Rubesrvaldo"
            };

            minhaLista.ForEach(x => Console.WriteLine(x));

            //foreach (var item in minhaLista)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey(true);
        }
    }
}
