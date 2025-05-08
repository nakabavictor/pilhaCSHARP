using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Fila
    {
        private Pessoa primeira;
        private Pessoa ultima;
        private int tamanhofila;

        public Fila()
        {
            Pessoa vazia = new Pessoa();
            primeira = vazia;
            ultima = vazia;
            tamanhofila = 0;
        }

        private Boolean filaVazia()
        {
            return tamanhofila == 0 ? true : false;
        }

        public void Enfileirar(Pessoa pessoa)
        {
            Pessoa temp;
            temp = pessoa;
            ultima.Proxima = temp;
            ultima = temp;
                
            tamanhofila++;
        }

        public int tamanhoFila()
        {
            int tamanho = 0;
            Pessoa aux = primeira.Proxima;

            while (aux != null)
            {
                tamanho++;
                aux = aux.Proxima;
            }
            return tamanho;
        }

        public string Desenfileirar()
        {
            if (!filaVazia())
            {
                Pessoa desenfileirado;
                desenfileirado = primeira.Proxima;
                primeira.Proxima = primeira.Proxima.Proxima;
                tamanhofila--;
                return desenfileirado.getNome;
            }
            else
                throw new Exception("Não foi possível desempilhar: a pilha está vazia!");
        }

        public void MostrarFila()
        {
            Pessoa fila = primeira.Proxima;
            if (!filaVazia())
            {
                Console.WriteLine("Comecando pelo primeiro: ");
                for (int i = 0; i < tamanhofila; i++)
                {
                    Console.WriteLine("Nome : " + fila.getNome + ". Idade: " + fila.getIdade);
                    if (fila.Proxima != null)
                        fila = fila.Proxima;

                }
            }
            else
                throw new Exception("Não foi possível mostrar a pilha: a pilha está vazia!");
        }
    }
}
