using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadostroCores
{
    class Program
    {
        static List<string> cores = new List<string>();
        static void Main(string[] args)
        {
            ShowMenu();
            var menuEscolha = "0";
            while (menuEscolha !="3")
            {
                menuEscolha = MenuCores();

                switch (menuEscolha)
                {
                    case "1":

                        Registro();
                        break;


                    case "2":

                        Listar();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Clear();
            }

        }

        static void Listar()
        {
            Console.WriteLine("Lista de Cores");
            cores.ForEach(x => Console.WriteLine(x));
            Console.ReadKey(true);

        }
        static void Registro()
        {
            Console.WriteLine("Digite o nome da COR:");
            var corEscolhida = Console.ReadLine();
            cores.Add(corEscolhida);
            Console.WriteLine("Cor adicionada ao Registro");
            Thread.Sleep(700);
        }
        static string  MenuCores()
        {
            Console.WriteLine("Digite o número para o Menu desejado!");
            Console.WriteLine("1 - Resgistrar Cores");
            Console.WriteLine("2 - Listar Cores");
            Console.WriteLine("3 - Sair do Sistema");
            return Console.ReadLine();
        }
        static void ShowMenu()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*****          Cadastro de Cores          *****");
            Console.WriteLine("***********************************************");
        }

    }
}
