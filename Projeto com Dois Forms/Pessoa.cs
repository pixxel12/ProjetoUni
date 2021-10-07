using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_com_Dois_Forms
{
    class Pessoa
    {
        private string nome;
        private string sobrenome;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Email { get => email; set => email = value; }

        public Pessoa() {}

        public Pessoa(string nome, string sobrenome, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;

        }

        // metodo que retorna de uma unica vez os dados da pessoa
        // em formato pessoal
        public string listaDados()
        {
            return  "Nome:" + nome + Environment.NewLine +
                    "Sobrenome:" + sobrenome + Environment.NewLine +
                    "e-mail: " + email + Environment.NewLine; 
        }
    }
}
