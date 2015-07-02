using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionários
{
    class Program
    {
        static void Main(string[] args)
        { 

//    Faça um programa que leia um número N, que é a quantidade de funcionários de uma empresa.
//Em seguida, leia todas as informações de cada funcionário (CPF, Nome, Data de nascimento, Data de admissão na empresa e salário) 
//e calcule o novo salário de cada funcionário de acordo com a tabela abaixo:

// ___________________________________
//|  Data de Admissão  |   Aumento    |
//|-----------------------------------|
//|  A partir de 2014  |   R$ 423,45  |
//|-----------------------------------|
//|  De 2010 a 2013    |     9,84%    |
//|-----------------------------------|
//|  De 2000 a 2009    |     16,4%    |
//|-----------------------------------|
//|       Até 1999     |     22,6%    |
//|____________________|______________|

            int n = int.Parse(Console.ReadLine());
           
            string [] nome = new string[n];
            int [] CPF = new int[n];
            int [] DAE = new int[n];
            int [] DaNascimento = new int[n];
            double [] Salario = new double[n];
            double [] NSalario = new double[n];

            for (int i = 0; i < n; i++)
            {
                nome[i] = Console.ReadLine();
                CPF[i] = int.Parse(Console.ReadLine());
                DAE[i] = int.Parse(Console.ReadLine());
                DaNascimento[i] = int.Parse(Console.ReadLine());
                Salario[i] = int.Parse(Console.ReadLine());

                if (DAE[i] >= 2014)
                {
                    NSalario[i] = (Salario[i] + 423.45);
                }
                else if ((DAE[i] >= 2010) && (DAE[i] <= 2013))
                {
                    NSalario[i] = Salario[i] + ((Salario[i] * 9.84) / 100);
                }
                else if ((DAE[i] >= 2000) && (DAE[i] <= 2009))
                {
                    NSalario[i] = Salario[i] + ((Salario[i] * 16.4) / 100);
                }
                else if (DAE[i] <= 1999)
                {
                    NSalario[i] = Salario[i] + ((Salario[i] * 22.6) / 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nome: {0}", nome[i]);
                Console.WriteLine("CPF: {0}", CPF[i]);
                Console.WriteLine("Data de Nascimento: {0}", DaNascimento[i]);
                Console.WriteLine("Data de Admição a Empresa: {0}", DAE[i]);
                Console.WriteLine("Salário Antigo: {0}", Salario[i]);
                Console.WriteLine("Novo Salário: {0}", NSalario[i]);
            }

        }
    }
}
