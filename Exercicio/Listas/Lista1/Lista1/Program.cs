using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args) {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio6();
            Exercicio7();
            Exercicio8();
        }
               
        static void Exercicio1()
        {
            
            Console.WriteLine("Começo Exercicio 1.");
            Console.WriteLine("");

            int num;
            
            Console.WriteLine("Calculo de Fatorial");
            
            Console.Write("Digite o número que deseja seu fatorial: ");
            num = int.Parse(Console.ReadLine());

            int result;

            result = num;

            for (int i = num - 1; i > 1; i--)
            {
                result *= i;
            }
            
            Console.WriteLine("O Fatorial do número digitado é: {0}", result);

            Console.WriteLine("");
            Console.WriteLine("Final do Exercicio 1.");
            Console.WriteLine("");
       
        }
        static void Exercicio2()
        {
            Console.WriteLine("");
            Console.WriteLine("Não consegui terminar. Exercicio 2");
            Console.WriteLine("");
        }

        static void Exercicio3()
        {
            Console.WriteLine("");
            Console.WriteLine("Não consegui terminar. Exercicio 3");
            Console.WriteLine("");
        }

        static void Exercicio4()
        {
            Console.WriteLine("Começo Exercicio 4.");
            Console.WriteLine("");

            int jogador1 = 0;
            int jogador2 = 0;
            string jog1 = "1";
            string jog2 = "2";
            string nomedojog;
            bool pontos = true;

            Console.WriteLine("O jogo vai começar.");

            while (pontos)
            {

                Console.Write("Quem fez o ponto ?: ");
                nomedojog = Console.ReadLine();
                if (jog1 == nomedojog)
                {
                    jogador1++;

                }
                else if (jog2 == nomedojog)
                {
                    jogador2++;
                }

                if ((jogador1 == 21 && jogador1 >= jogador2 + 2) || (jogador1 > 21 && jogador1 == jogador2 + 2))
                {
                    Console.WriteLine("O Jogador 1 venceu!");
                    pontos = false;
                }

                else if ((jogador2 == 21 && jogador2 >= jogador1 + 2) || (jogador2 == 21 && jogador2 >= jogador1 + 2))
                {
                    Console.WriteLine("O Jogador 2 venceu!");
                    pontos = false;
                }

            }

            Console.WriteLine("Pontuação Jogador1 = {0}", jogador1);
            Console.WriteLine("Pontuação Jogador1 = {0}", jogador2);

            Console.WriteLine("");
            Console.WriteLine("Final do Exercicio 4.");
            Console.WriteLine("");
        
       }

        static void Exercicio5()
        {
            Console.WriteLine("");
            Console.WriteLine("Não consegui terminar. Exercicio 5");
            Console.WriteLine("");
        }
        static void Exercicio6() 
        {

            Console.WriteLine("Começo Exercicio 6.");

            //Exercício 6
            double altura = 0;
            double maltura = 0;
            double maltura2 = 0;
            int NDMulheres = 0;
            int NDMulheres2 = 0;
            string mulher = "";


            while (mulher != "Fim")
            {

                Console.Write("Nome: ");
                mulher = Console.ReadLine();

                if (mulher != "Fim")
                {

                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());

                    if (altura > maltura)
                    {
                        maltura2 = maltura;
                        maltura = altura;
                        NDMulheres = 1;
                    }

                    else if (maltura == altura)
                    {
                        NDMulheres++;
                    }

                    else if (altura > maltura2)
                    {
                        maltura2 = altura;
                        NDMulheres2 = 1;
                    }

                    if (maltura2 == altura)
                    {
                        NDMulheres2++;
                    }

                }

            }

            Console.WriteLine("Altura 1: {0}. Possui {1} com a mesma altura. Altura 2: {2}. Possui {3} com a mesma altura", maltura, NDMulheres, maltura2, NDMulheres2);


            Console.WriteLine("Final do Exercicio 6.");
        }
        static void Exercicio7()
        { //Exercício 7
            Console.WriteLine("");
            Console.WriteLine("Tive muita dificuldade no exercicio 7 e acabei não fazendo.");
            Console.WriteLine("");
        }
        static void Exercicio8()
        {

            Console.WriteLine("Começo Exercicio 8.");


            //Exercício 8
            int n;
            int soma = 0;

            Console.Write("Digite N: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                soma += i;

            }

            Console.WriteLine("Resultado: {0}", soma);

            Console.WriteLine("Final do Exercicio 8.");
        }
    }

}
