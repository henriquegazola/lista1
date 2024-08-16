using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NOMES:Henrique, Augustus, Samuel, Felipe, Estefanie e Vinicius de paula.
            // ATIVIDADE PARA FAZER AS QUATRO OPERAÇÕES
            string nome;
            int n1, n2, soma;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.Write(nome + " a soma de {0} e {1} é " + soma);
            Console.ReadKey();
        }
    }
}
