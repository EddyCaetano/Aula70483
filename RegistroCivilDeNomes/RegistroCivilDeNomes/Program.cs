using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCivilDeNomes
{
    class Program
    {
        static List<string> listaDeNomes = new List<string>();
        static void Main(string[] args)
        {
            MsgInicial();

            var menuEscolhido = "0";

            while(menuEscolhido != "5")
            {                
                menuEscolhido = MostrarMenu();

                switch (menuEscolhido)
                {
                    case "1":

                        RegistrarNome();
                        break;

                    case "2":

                        ListarNome();
                        break;

                    default:
                        Console.WriteLine("Menu Inválido!");
                        break;
                }

                Console.Clear();

            }

            Console.ReadKey(true);
        }
        static void MsgInicial()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("******Sistema de Registro********");
            Console.WriteLine("*********************************");
        }
        static void ListarNome()
        {
            Console.WriteLine("Listagem de Nomes Selecionado.");

            listaDeNomes.ForEach(x => Console.WriteLine($"Nome: {x}"));

            Console.WriteLine("Listagem de nome finalizada!");
            Console.ReadKey(true);
        }
        static void RegistrarNome()
        {
            Console.WriteLine("Registro de Nome Selecionado.");
            Console.WriteLine("Informe um Nome:");
            var nomeInformado = Console.ReadLine();

            listaDeNomes.Add(nomeInformado);


            Console.WriteLine("Nome informado com sucesso!");
            Console.ReadKey(true);

        }
        static string MostrarMenu()
        {
            Console.WriteLine("Digite o número para a opção desejada");
            Console.WriteLine("1 - Registrar Nome");
            Console.WriteLine("2 - Listar Nomes");
            Console.WriteLine("3 - Editar Nomes");
            Console.WriteLine("4 - Excluir Nomes");
            Console.WriteLine("5 - Sair do Sistema");

            return Console.ReadLine();
        }
    }
}
