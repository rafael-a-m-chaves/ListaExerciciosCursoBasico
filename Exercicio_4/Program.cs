using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que gera a tabuada do número informado pelo usuário.

            Console.WriteLine("Digite um numero para gerar a sua tabuada ");

            int numeroInformado = Convert.ToInt32(Console.ReadLine());

            for(var i = 1; i <= 10; i++)
            {
                Console.WriteLine(numeroInformado + " X " + i+" = "+ numeroInformado*i);
            }
            Console.ReadKey();
        }
    }
}
