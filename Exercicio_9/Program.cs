using System;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa de conversão de base numérica. O programa deverá apresentar
            uma tela de entrada com as seguintes opções:
            1 – Adição
            2 – Subtração
            3 – Multiplicação
            4 – Divisão
            Informe a opção:
            A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois
            números. Em seguida, o programa deve exibir o resultado da opção indicada pelo
            usuário e perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta
            seja “S” ou “s”, deverá voltar ao menu, caso contrário deverá encerrar o programa */

            var separacao = "_________________________________________________________________________________";
            bool condicao = true;

            while (condicao)
            {
                Console.WriteLine("Digite o numero de uma das opções abaixo: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                int opcao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(separacao);

                Console.WriteLine("Digite o 1° numero");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o 2° numero");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(separacao);
                if (opcao == 1)
                {
                    Console.WriteLine("O valor da Soma é: " + (num1 + num2));
                }
                else if(opcao == 2)
                {
                    Console.WriteLine("O valor da Subtração é: " + (num1 - num2));
                }
                else if(opcao == 3)
                {
                    Console.WriteLine("O valor da Multiplicação é: " + (num1 * num2));
                }
                else if(opcao == 4)
                {
                    Console.WriteLine("O valor da Divisão é: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Como a opção escolhida esta fora do range irei exibir todos os calculos possiveis");

                    Console.WriteLine("O valor da Soma é: " + (num1 + num2));

                    Console.WriteLine("O valor da Subtração é: " + (num1 - num2));

                    Console.WriteLine("O valor da Multiplicação é: " + (num1 * num2));

                    Console.WriteLine("O valor da Divisão é: " + (num1 / num2));

                }

                Console.WriteLine(separacao);

                Console.WriteLine("Deseja efetura outro calculo? (Digite 'S' ou 's'caso queira)");

                string controle = Console.ReadLine();

                if (controle == "S" || controle == "s") condicao = true;
                else condicao = false;

                Console.Clear(); // limpa a tela

            }
        }
    }
}
