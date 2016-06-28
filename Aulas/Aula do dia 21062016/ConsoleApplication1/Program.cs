using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de carros que serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());
            
            List<Carro> carros = new List<Carro>();

            for (int i = 0; i < n; i++)
			{
                Carro c = new Carro();
                Console.Write("\r\nDigite o Modelo do Carro: ");
                c.Modelo = Console.ReadLine();
                Console.Write("\r\nDigite a Placa do Carro: ");
                c.Placa = Console.ReadLine();
                Console.Write("\r\nDigite o Ano do Carro: ");
                c.Ano = int.Parse(Console.ReadLine());
			}

            Console.WriteLine("Digite a placa do Carro a ser consultada");
            string consult = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (consult == carros[i].Placa)
                {
                    Console.Write("\r\nOk!\r\n");
                    Console.Write("\r\nModelo: {0}.\r\nPlaca: {1}.\r\nAno: {2}.\r\n",carros[i].Modelo, carros[i].Placa, carros[i].Ano);
                }
            }
        }
    }
}
