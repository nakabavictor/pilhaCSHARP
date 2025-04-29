using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILHA
{
    internal class Pilha
    {
        private Pessoa topo;
        private Pessoa fundo;

        public Pilha()
        {
            Pessoa vazia;
            vazia = new Pessoa(); 
            topo = new Pessoa();
            fundo = new Pessoa();
        }

        public Boolean pilhaVazia()
        {
            Boolean resp;

            return resp = topo == fundo ? true : false;
        }

        public void Empilhar(Pessoa pessoa)
        {
            Pessoa temp;
            temp = pessoa;
            temp.Proxima = topo;
            topo = temp;
        }

        public string Desempilhar()
        {
            if (!pilhaVazia())
            { 
                Pessoa desempilhado;
                desempilhado = topo;
                topo = topo.Proxima;
                desempilhado.Proxima = null;
                return (desempilhado.getNome);
            }
            else
                throw new Exception("Não foi possível desempilhar: a pilha está vazia!");
        }

        public void Consultartopo()
        {
            Console.WriteLine("Nome de quem esta no topo: "+ topo.getNome + "Idade de quem esta no topo: " + topo.getIdade);
        } 
    }
}
