using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que receba uma quantidade definida pelo usuário de números e
              pegue o maior e o menor número informado e apresente na tela.*/

            List<int> numeros = new List<int>();

            Console.WriteLine("Informe a quantidade de numeros que desaja informar ");
            int controle = Convert.ToInt32(Console.ReadLine());

            for(var i = 1; i <= controle; i++)
            {
                Console.WriteLine("Digite o " + i + "° numero");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));

            }

            Console.WriteLine("o menor numero informado foi: " + numeros.Min());
            Console.WriteLine("");
            Console.WriteLine("O maior numero informado foi: " + numeros.Max());

            Console.ReadLine();
        }
    }
}
