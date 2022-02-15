using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Escreva um programa que leia:
               - A quantidade de números que o usuário deseja informar.
               - Leia cada número e informe a média aritmética e a soma deles.
             */

            Console.WriteLine("Digite A Quantidade de Numeros que deseja informar ");
            int quantidadeDeNumerosEsperados = Convert.ToInt32(Console.ReadLine());
            int somaNumerosInformados = 0;

            for(var i = 1; i <= quantidadeDeNumerosEsperados; i++)
            {
                Console.WriteLine("Digite o " + i + "º numero ");
                somaNumerosInformados = somaNumerosInformados + Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("A Soma dos Numeros Informados é:  " + somaNumerosInformados);
            Console.WriteLine("");
            Console.WriteLine("A Media Aritimetica dos numeros informados é:  " + somaNumerosInformados / quantidadeDeNumerosEsperados);

            Console.ReadLine();
        }
    }
}
