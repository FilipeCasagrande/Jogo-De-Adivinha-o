﻿using System;
using static System.Net.Mime.MediaTypeNames;

namespace JogoDeAdivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int contarray = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Jogo Da Adivinhação");
                Console.WriteLine("----------------------------------------");


                Console.WriteLine("Escolha o nivel de dificuldade");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Normal (5 tentativas)");
                Console.WriteLine("3 - Díficil (3 tentativas)");
                Console.WriteLine("----------------------------------------");

                Console.Write("Digite sua escolha: ");
                string escolhadificuldade = Console.ReadLine();
                string Numerod;
                decimal pontuacao = 30m;
                decimal numero = 0m;

                int totaldetentativas = 0;

                if (escolhadificuldade == "1")
                    totaldetentativas = 10;
                else if (escolhadificuldade == "2")
                    totaldetentativas = 5;
                else
                    totaldetentativas = 3;


                Random gdn = new Random();
                int ns = gdn.Next(1, 21);


                for (int tentativa = 1; tentativa <= totaldetentativas; tentativa++)
                {

                    Console.Clear();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {totaldetentativas}");
                    Console.WriteLine("----------------------------------------");

                    Console.Write("Digite um número (de 1 à 20 )para Chutar: ");
                    int Numerochute = Convert.ToInt32(Console.ReadLine());
                    if (array.Contains(Numerochute))
                    {

                        while (array.Contains(Numerochute))
                        {
                            Console.WriteLine("Número ja foi escolhido digite outro número");
                            Numerochute = Convert.ToInt32(Console.ReadLine());
                        }

                    }
                    array[contarray] = Numerochute;



                    if (Numerochute == ns)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Parabéns você acertou! ");
                        Console.WriteLine("Sua pontuação foi: " + pontuacao);
                        Console.WriteLine("----------------------------------------");
                        break;
                    }

                    else if (tentativa == totaldetentativas)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($"Que pena! Você usou todas as tentativas. O número era {ns}.");
                        Console.WriteLine("----------------------------------------");
                        break;
                    }


                    else if (Numerochute > ns)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("O numero digitado foi Maior que o número secreto!");
                        Console.WriteLine("----------------------------------------");
                        numero = (Numerochute - ns) / 2m;
                        pontuacao = pontuacao - numero;
                    }
                    else if (Numerochute < ns)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("O numero digitado foi Menor que o número secreto!");
                        Console.WriteLine("----------------------------------------");
                        numero = (Numerochute - ns) / 2;
                        if (numero < 0m)
                        {
                            numero = -numero;
                        }
                        pontuacao = pontuacao - numero;
                    }
                    if (pontuacao < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine($"Que pena! sua pontuação chegou a 0 você perdeu!");
                        Console.WriteLine("----------------------------------------");
                        array = new int[10];
                        contarray = 0;
                        break;
                        continue;
                    }

                    Console.WriteLine("Mostrar números ja digitados? [S] - Mostrar, [N] continuar: ");
                    Numerod = Console.ReadLine();

                    if (Numerod == "s")
                    {
                        for (int cont = 0; cont <= contarray; cont++)
                        {
                            Console.WriteLine("Número: " + array[cont]);
                        }
                        Console.WriteLine("Precione Enter para continuar");
                        Console.ReadLine();
                    }
                    numero = 0m;
                    contarray++;
                }

                Console.WriteLine("Deseja Continuar S/N?");
                string opcaocontinuar = Console.ReadLine().ToUpper();

                if (opcaocontinuar == "N")
                    break;

            }
        }
    }
}
