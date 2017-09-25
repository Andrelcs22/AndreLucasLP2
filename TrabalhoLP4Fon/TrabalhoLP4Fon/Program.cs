using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TrabalhoLP4Fon
{
    class Program
    {

        public enum ItemMenu
        {
        
        Cadastrar=1,
        Consultar,
        Sair,
                
        }
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            TimeSpan ts;
            sw.Start();

            Console.WriteLine("Cadastro de Nome e Idade.");
            Console.Write("\r\nCadastrar = 1.\r\nConsultar = 2. \r\nSair = 3.");
            Console.Write("\r\n\r\nDigite qual caminho deseja seguir: ");
            
     
            Dictionary<string,DateTime> d = new Dictionary<string,DateTime>();
            string nome;
            int opc;
            
            try 
	        {	        
		    
                opc = int.Parse(Console.ReadLine());
           
                    
                if (opc == (int)ItemMenu.Cadastrar)
                {
                    Console.Write("\r\nDigite nome e sobrenome: ");
                    nome = Console.ReadLine();
                    Console.Write("\r\nDigite data de nascimento(DD/MM/AAAA): ");
                    DateTime nasc = new DateTime();
                    nasc = DateTime.Parse(Console.ReadLine());
                    d.Add(nome, nasc);

                    Console.Write("\r\nCadastrar = 1.\r\nConsultar = 2. \r\nSair = 3.");
                    Console.Write("\r\n\r\nDigite qual caminho deseja seguir: "); 
                    
                    opc = int.Parse(Console.ReadLine());
                }
                if(opc == (int)ItemMenu.Consultar)
                {
                    foreach (KeyValuePair<string, DateTime> x in d)
                    {
                        Console.Write("\r\n");
                        Console.WriteLine(x);
                    }
                    Console.Write("\r\nCadastrar = 1.\r\nConsultar = 2. \r\nSair = 3.");
                    Console.Write("\r\n\r\nDigite qual caminho deseja seguir: ");

                    opc = int.Parse(Console.ReadLine());
                }
                else if(opc == (int)ItemMenu.Sair)
                {
                    //
                }
            }

            catch (Exception e)
	        {
                Console.WriteLine("\r\nAlgum campo foi preenchido incorretamente.\r\n");
	        }

            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine("\r\nVoce está logado por: {0} minutos : {1} segundos : {2} milisegundos.\r\n", ts.Minutes, ts.Seconds, ts.Milliseconds);
        } 
	}
	
    }

