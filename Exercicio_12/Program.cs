using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que determine o maior e o menor entre os números lidos. A
            condição de parada é a entrada de um valor 0.*/

            List<int> numeros = new List<int>();

            while (true)
            {
                Console.WriteLine("Digite um numero (0 encerra a aplicação)");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 0) break;
                numeros.Add(numero);
            }

            Console.WriteLine("O maior valor informado foi: " + numeros.Max());
            Console.WriteLine("O menor valor informado foi: " + numeros.Min());
            Console.ReadKey();
        }
    }
}
