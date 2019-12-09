using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFelipe
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIOS 01 E 02
            //Console.WriteLine("Por favor, Digite o Seu Nome");
            //string nome = Console.ReadLine();
            //Console.WriteLine("*******************************************************************************");
            //Console.WriteLine($"****Seja bem vindo ao sistema de testes {nome}****");
            //Console.WriteLine("*******************************************************************************");


            // EXERCÍCIOS 03
            //Console.WriteLine("Por favor, Digite o Seu Nome");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Por favor, Digite sua idade");
            //var idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("*******************************************************************************");
            //if (idade > 18)
            //{
            //    Console.WriteLine($"Parabéns {nome} vc é um adulto");
            //}
            //else
            //{
            //    Console.WriteLine($"Calma {nome} vc logo será um adulto");
            //}
            //Console.WriteLine("*******************************************************************************");

            Console.WriteLine("DIGITE UM TEXTO AQUI:");
            string texto = Console.ReadLine();

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Seu texto con tém {texto.Length} caracteres.");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");


            Console.WriteLine("Pressione Uma tecla para sair!");
            Console.ReadKey(true);
        }
    }
}
