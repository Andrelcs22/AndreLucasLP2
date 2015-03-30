using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_do_dia_240315
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double nums;
            double soma = 0;
            double maior = 0;
            double menor = 123479163512834;
            
            Console.Write("Digite um número para que sejam feitos os cálculos: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Escreva mais {0} numeros: ", x);


            for (int i = 0; i < x; i++)
            {
               nums = double.Parse(Console.ReadLine());
               soma = nums + soma;
                if (maior < nums)
                {
                    maior = nums;
                }
                if (menor > nums)
                {
                    menor = nums;
                }
            }
                 
            Console.WriteLine("Seu resultado. Maior {0}. Menor {1}. Soma {2}.",  maior, menor, soma);

        }
    }
}
