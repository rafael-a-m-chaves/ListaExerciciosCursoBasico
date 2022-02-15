using System;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba o salário e calcule o imposto de renda devido para cada
            salário informado, se for informado 0 feche o programa*/

            while (true)
            {
                Console.WriteLine("Digite o valor do salario (0 finaliza)");
                decimal salario = Convert.ToDecimal(Console.ReadLine());
                if (salario == 0 || salario == 0.0M) break;
                else if (salario < 1903.99M) Console.WriteLine("Este Salario não paga imposto");
                else if (salario < 2826.66M) Console.WriteLine("Imposto é:  " + (salario*(7.5M/100)));
                else if (salario < 3751.06M) Console.WriteLine("Imposto é:  " + (salario * (15.0M / 100)));
                else if (salario < 4664.68M) Console.WriteLine("Imposto é:  " + (salario * (22.5M / 100)));
                else Console.WriteLine("Imposto é:  " + (salario * (27.5m / 100)));
            }
        }
    }
}
