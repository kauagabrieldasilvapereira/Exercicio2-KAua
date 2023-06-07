using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_KAua
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] vet2;
            int t;
            float soma = 0, media = 0;
            Console.WriteLine("Entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);  //gerar numeros aleatorios 
                soma = soma + vet2[i];
            }
            {
                for (int i = 0; i < t; i++)
                    Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            media = soma;
            media = media / t;
            Console.WriteLine("Média é {0}", media);
        }
        public static void Exercicio2()
        {
            int[] vet1;
            int t;
            float som = 0, somas = 0, somasss = 0;
            Console.WriteLine("Entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet1 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet1[i] = rand.Next(10, 50);  //gerar numeros aleatorios 
                if (vet1[i] % 2 == 0)
                {
                    som = som + vet1[i];
                }
                else
                {
                    somas = somasss + vet1[i];
                }
            }
            {
                for (int i = 0; i < t; i++)
                    Console.WriteLine("posição[{0}] = {1}", i, vet1[i]);
            }
            Console.WriteLine("pares {0}", somas);
            Console.WriteLine("pares {0}", somasss);

        }
        public static void Exercicio3()
        {
            int[] vet3;
            int t;
            Console.WriteLine("Entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet3 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet3[i] = rand.Next(0, 50);  //gerar numeros aleatorios 

                for (int i; vet3[i] == i; i++)
                {
                    Console.WriteLine(vet3[i]);
                }
                {
                    for (int i = 0; i < t; i++)
                        Console.WriteLine("posição[{0}] = {1}", i, vet3[i]);
                }
            }
        }
        public static void Exercicio4()
        {
            int[] vet4;
            int t;
            float soma = 0, media = 0;
            Console.WriteLine("Entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet4 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet4[i] = rand.Next(10, 50);  //gerar numeros aleatorios 
                if (vet4[i] % 3 == 0 | vet4[i] % 5 == 0)
                {
                    soma = soma + vet4[i];
                    media = soma;
                    media = media / t;
                    Console.WriteLine("Sua média aritmetica é {0}", media);
                }
                else
                {
                    Console.WriteLine("Não foi possivel");
                }
                for (int i; vet4[i] == i; i++)
                {
                    Console.WriteLine(vet4[i]);
                }
                {
                    for (int i = 0; i < t; i++)
                        Console.WriteLine("posição[{0}] = {1}", i, vet4[i]);
                }
            }
        }

        public static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("=================MENU=================");
                Console.WriteLine("Para sair - digite 0");
                Console.WriteLine("Para executar o exercicio 1 - digite 1");
                Console.WriteLine("Para executar o exercicio 2 - digite 2");
                Console.WriteLine("Para executar o exercicio 3 - digite 3");
                Console.WriteLine("Para executar o exercicio 4 - digite 4");
                Console.WriteLine("======================================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar o programa");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                }
            } while (opcao != 0);
        }
    }
}

           
       
     
