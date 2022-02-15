using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que gera e escreve os números ímpares dos números lidos entre 0 e 200.

            for (var i = 1; i < 200; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
