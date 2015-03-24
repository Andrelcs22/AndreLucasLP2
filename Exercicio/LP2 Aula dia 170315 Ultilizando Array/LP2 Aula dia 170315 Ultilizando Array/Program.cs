using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_Aula_dia_170315_Ultilizando_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList x = new ArrayList();
            int delta = 1;
            int y = 0;
            int media = 0;
            int i =0;

            while (delta != 0)
            {
                Console.Write("Digite o número: ");
                delta = int.Parse(Console.ReadLine());
                if (delta > 0)
                {
                    x.Add(delta);
                }
             }
            foreach (int z in x)
            {
                y = y + z;
                i++;
            }

            media = y / i;
                       
            Console.Write("Média é: {0}", media);
            

        }
    }
}
