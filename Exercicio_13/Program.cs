using System;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que calcule um plano de salário de um funcionário da Empresa XYZ,
             onde deve ser informado a quantidade de anos de trabalho e o salário inicial. É regra
             da empresa é aumentar o salário nos 3 primeiros anos em 50% a cada ano, nos demais
             ela aumenta em 100% a cada ano trabalhado e a cada 10 anos ela dá um bônus de
             10% de aumento.*/

            Console.WriteLine("Digite a quantidade de anos trabalhado ");
            int anosTrabalhados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salario do funcionario ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            for(var i = 1; i <= anosTrabalhados; i++)
            {
                if (i <= 3) salario = salario + (salario * (50.0M / 100));
                if (i > 3) salario = salario + salario;
                if (i % 10 == 0) salario = salario + (salario * (10.0M / 100));
            }

            Console.WriteLine("O novo salario é: " + salario);
        }
    }
}
