using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Hotel.Entidades
{
    public class Funcionario
    {
        public int fun_id { get; set; }
        public string fun_nome { get; set; }
        public string fun_sobrenome { get; set; }
        public string fun_cpf { get; set; }
        public string fun_titulo { get; set; }

        public Funcionario(int id, string nome, string sobrenome, string cpf, string titulo){
            this.fun_id = id;
            this.fun_nome = nome;
            this.fun_sobrenome = sobrenome;
            this.fun_cpf = cpf;
            this.fun_titulo = titulo;
        }

    }
}
