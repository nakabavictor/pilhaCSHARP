using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Pilha
    {
        private Pessoa topo;
        private Pessoa fundo;
        private int tamanhopilha;

        public Pilha()
        {
            Pessoa vazia;
            vazia = new Pessoa();
            topo = vazia;
            fundo = vazia;
            tamanhopilha = 0;
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
            tamanhopilha++;
        }

        public string Desempilhar()
        {
            if (!pilhaVazia())
            {
                Pessoa desempilhado;
                desempilhado = topo;
                topo = topo.Proxima;
                desempilhado.Proxima = null;
                tamanhopilha--;
                return (desempilhado.getNome);
            }
            else
                throw new Exception("Não foi possível desempilhar: a pilha está vazia!");
        }

        public void MostrarPilha()
        {

            Pessoa primeira = topo;
            if (!pilhaVazia())
            {
                Console.WriteLine("Comecando pelo topo: ");
                for (int i = 0; i < tamanhopilha; i++)
                {
                    Console.WriteLine("Nome : " + primeira.getNome + ". Idade: " + primeira.getIdade);
                    if (primeira.Proxima != null)
                        primeira = primeira.Proxima;
                }
            }
            else
                throw new Exception("Não foi possível mostrar a pilha: a pilha está vazia!");

        }

        public void Consultartopo()
        {
            Console.WriteLine("Nome de quem esta no topo: " + topo.getNome + ". Idade de quem esta no topo: " + topo.getIdade);
        }
    }
}
