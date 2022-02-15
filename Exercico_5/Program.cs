using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que receba 4 números e apresente a soma dos números pares e depois dos números impares.
            int somaPar = 0;
            int somaImpar = 0;

            for(var i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite o " + i + "° numero");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 != 0) somaImpar = somaImpar + numero;

                else somaPar = somaPar + numero;
            }

            Console.WriteLine("A soma dos numeros pares é: " + somaPar);
            Console.WriteLine("A soma dos numeros impares é: " + somaImpar);
            Console.ReadKey();
        }
    }
}
