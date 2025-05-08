using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilha: ");
            Pilha pilha1 = new Pilha();
            Pessoa pessoa00 = new Pessoa(23, "Lucas");
            Pessoa pessoa0 = new Pessoa(18, "Joao");
            Pessoa pessoa1 = new Pessoa(20, "Pedro");
            pilha1.Empilhar(pessoa00);
            pilha1.Empilhar(pessoa0);
            pilha1.Empilhar(pessoa1);
            
            pilha1.MostrarPilha();
            pilha1.Consultartopo();
            string nome = pilha1.Desempilhar();
            Console.WriteLine("O desempilhado foi: " + nome + "\n");
            pilha1.MostrarPilha();


            Console.WriteLine("\n\nFila: ");
            Fila fila = new Fila();
            Pessoa pessoa4 = new Pessoa(23, "Lucas2");
            Pessoa pessoa3 = new Pessoa(18, "Joao2");
            Pessoa pessoa2 = new Pessoa(20, "Pedro2");
            fila.Enfileirar(pessoa4);
            fila.Enfileirar(pessoa3);
            fila.Enfileirar(pessoa2);
           
            
            fila.MostrarFila();
            string nome2 = fila.Desenfileirar();
            Console.WriteLine("O desenfileirado foi: " + nome2 + "\n");
            fila.MostrarFila();

            Console.ReadLine();
        }
    }
}
