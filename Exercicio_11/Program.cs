using System;
using System.Collections.Generic;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que dada o nome e idade de um nadador, classifique-o em uma das
            seguintes categorias:
            - Infantil A = 5 a 7 anos
            - Infantil B = 8 a 11 anos
            - Juvenil A = 12 a 13 anos
            - Juvenil B = 14 a 17 anos
            - Adultos = Maiores de 18 anos
            Ao final apresente as categorias e o nome dos nadadores e idade de cada uma dentro
            das suas respectivas categorias de natação.*/

            List<string> infantilA = new List<string>();
            List<string> infantilB = new List<string>();
            List<string> juvenilA = new List<string>();
            List<string> juvenilB = new List<string>();
            List<string> adulto = new List<string>();

            while (true)
            {
                Console.WriteLine("Digite o nome do nadador ('finalizar' encerra o programa)");
                string nome = Console.ReadLine();
                if (nome == "finalizar") break;

                Console.WriteLine("Digite a idade do nadador: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 5 && idade <= 7) infantilA.Add(nome);
                else if (idade <= 11) infantilB.Add(nome);
                else if (idade <= 13) juvenilA.Add(nome);
                else if (idade <= 17) juvenilB.Add(nome);
                else if (idade >= 18) adulto.Add(nome); 
            }

            var separacao = "_______________________________________________________________________________";

            Console.WriteLine(separacao);
            Console.WriteLine();

            Console.WriteLine("Os nadadores informados por grupo são");

            Console.WriteLine(separacao);
            Console.WriteLine();

            Console.WriteLine("Infantil A");
            if(infantilA.Count > 0)
            {
                foreach(var item in infantilA)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine(separacao);
            Console.WriteLine();

            Console.WriteLine("Infantil B");
            if (infantilB.Count > 0)
            {
                foreach (var item in infantilB)
                {
                    Console.WriteLine(item);
                }
            }


            Console.WriteLine(separacao);
            Console.WriteLine();

            Console.WriteLine("Juvenil A");
            if (juvenilA.Count > 0)
            {
                foreach (var item in juvenilA)
                {
                    Console.WriteLine(item);
                }
            }


            Console.WriteLine(separacao);
            Console.WriteLine();

            Console.WriteLine("Juvenil B");
            if (juvenilB.Count > 0)
            {
                foreach (var item in juvenilB)
                {
                    Console.WriteLine(item);
                }
            }


            Console.WriteLine(separacao);
            Console.WriteLine();

            Console.WriteLine("Adulto");
            if (adulto.Count > 0)
            {
                foreach (var item in adulto)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
