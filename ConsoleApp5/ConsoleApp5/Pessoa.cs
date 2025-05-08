using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Pessoa
    {
        private int idade;
        private string nome;
        private Pessoa proxima;

        public Pessoa(int idade, string nome)
        {
            this.idade = idade;
            this.nome = nome;
            this.proxima = null;
        }

        public Pessoa()
        {
            nome = string.Empty;
            idade = 0;
            proxima = null;
        }

        public Pessoa Proxima
        {
            get { return proxima; }
            set { proxima = value; }
        }

        public int getIdade
        {
            get { return idade; }
        }

        public string getNome
        {
            get { return nome; }
        }
    }
}
