using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Fatorial_Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            

            Console.WriteLine("Calculo de Fatorial");
            

            Console.Write("Digite o número que deseja seu fatorial: ");
            num = int.Parse(Console.ReadLine());

            int result;
            
            result = num;

            for (int i = num -1; i > 1; i--)
            {
               result *= i;
                
            }
 

            Console.WriteLine("O Fatorial do número digitado é: {0}", result);
        }
    }
}
