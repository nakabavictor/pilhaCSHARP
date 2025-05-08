using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha1 = new Pilha();
            Pessoa pessoa1 = new Pessoa();
            Pessoa seupe = new Pessoa();
            Pessoa seupe2 = new Pessoa(23, "Lucas");
            seupe = new Pessoa(18, "Joao");
            pessoa1 = new Pessoa(20, "Pedro");
            pilha1.Empilhar(pessoa1);
            pilha1.Empilhar(seupe);
            pilha1.Empilhar(seupe2);
            pilha1.MostrarPilha();
            pilha1.Consultartopo();
            pilha1.Desempilhar();
            pilha1.Consultartopo();

            Console.ReadLine();
        }
    }
}
