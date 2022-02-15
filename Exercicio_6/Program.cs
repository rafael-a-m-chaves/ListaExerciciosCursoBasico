using System;
using System.Collections.Generic;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que calcule a nota média de cada aluno e a média da turma. O 
              programa deve receber o nome do aluno e a nota de cada bimestre (4 notas), ao 
              informar no nome do aluno o valor “finalizar” o programa deve realizar os cálculos da 
              média e apresentar na tela.*/

            Dictionary<string, decimal> alunos = new Dictionary<string, decimal>();
            decimal mediaTurma = 0;
            int controle = 0;
            while (true)
            {
                Console.WriteLine("Digite o nome do aluno ('finalizar' encerra a entrada de dados) ");
                string nome = Console.ReadLine();

                decimal notasAluno = 0;

                if (nome == "finalizar") break;

                for(var i =1; i < 5; i++)
                {
                    Console.WriteLine("Digite a " + i + "° nota");
                    decimal nota = Convert.ToDecimal(Console.ReadLine());
                    mediaTurma = mediaTurma + nota;
                    notasAluno = notasAluno + nota;
                    
                }

                notasAluno = notasAluno / 4;
                alunos.Add(nome, notasAluno);
                controle++;
            }

            foreach(var item in alunos)
            {
                Console.WriteLine(item.Key + " Obteve media: " + item.Value);
                Console.WriteLine("");
            }

            Console.WriteLine("A media da turma foi: " + mediaTurma / (controle * 4));

            Console.ReadKey();

        }
    }
}
