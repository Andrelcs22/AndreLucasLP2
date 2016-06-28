using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_do_dia_28062016
{
    class Pessoa
    {
        public string Nome {get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public int telCel { get; set; }
        public DateTime data_Nascimento { get; set; }

        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;       
        }
        public Pessoa(string cpf)
        {
            this.CPF = cpf;
        }
        
    }
}
