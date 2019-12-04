using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace registroFilmes
{
    class Program
    {
        static List<string> listaDeFilmes = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("**Sistema de Registro de Filme**");
            Console.WriteLine("********************************");


            var menuEscolhido = "0";

            while (menuEscolhido != "3")
            {
                Console.WriteLine("Digite o número para o Menu desejado!");
                Console.WriteLine("1 - Registrar Filme");
                Console.WriteLine("2 - Listar Filmes");
                Console.WriteLine("3 - Sair do Sistema");

                menuEscolhido = Console.ReadLine();

                switch (menuEscolhido)
                {
                    case "1":

                        Console.WriteLine("Informe o nome do seu filme:");
                        var nomeInformado = Console.ReadLine();

                        listaDeFilmes.Add(nomeInformado);

                        Console.WriteLine("Registro Realizado! Aperte \"Enter\" para sair");
                        //Timer t = new Timer(TimerCallback, null, 0, 2000);
                        Console.ReadKey(true);
                        break;

                    case "2":

                        Console.WriteLine("Filmes Registrados:");
                        listaDeFilmes.ForEach(x => Console.WriteLine($"Filme: {x}"));

                        Console.WriteLine("Lista de filmes exibidos com sucesso.");
                        Console.ReadKey(true);
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.Clear();
            }
            //Console.ReadKey(true);
        }
    }
}
