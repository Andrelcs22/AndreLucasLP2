using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_coordenada_28062016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de pontos que você irá colocar: ");
            int n = int.Parse(Console.ReadLine());

            double Gx=0;
            double Gy=0;

            double x1 = 0;
            double y1 = 0;
                      
            List<Ponto> pontos = new List<Ponto>();

            for (int i = 0; i < n; i++)
            {
               x1 = double.Parse(Console.ReadLine());
               y1 = double.Parse(Console.ReadLine());
               
               Ponto p = new Ponto(x1,y1);
               
                pontos.Add(p);
            }

            for (int j = 0; j < n; j++)
            {
                Gx += x1;

                Gy += y1;
            }
           double medX = Gx/n;
           double medY = Gy/n;

           Console.Write("\r\nA media dos pontos de x e y é respectivamente:\r\n{0}\r\n{1}\r\n", medX, medY);

        }
    }
}
