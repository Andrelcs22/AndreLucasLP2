using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_Aula_dia_170315
{
    class Program
    {
        static void Main()
        {

            //Cria as Variáveis
            int nums = 1;
            int y = 0;
            int z = 0;
            int media = 0;
            
            //Loop para digitar os numeros que serão adicionados a Y.
            while (nums != 0)
            {
                Console.Write("Digite o número: ");
                nums = int.Parse(Console.ReadLine());
                //Condição para os numeros diferentes de 0
                if (nums > 0)
                {
                    y = y + nums;
                    z++;   
                }
                
            }         
            
            //Calculo da media
            media = y / z;
            
            //Resultado Final da Média
            Console.Write("Média é: {0}", media);


            
            
            }
              
        }
    }


