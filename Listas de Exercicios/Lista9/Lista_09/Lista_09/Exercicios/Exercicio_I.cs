using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_I
    {
        public static void Executar()
        {
            const int totalNomes = 10;
            string[] nomes = new string[totalNomes];

            // 1. Entrada de dados: Leitura dos 10 nomes
            Console.WriteLine($"--- Digite {totalNomes} nomes ---");
            for (int i = 0; i < totalNomes; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            // 2. Exibição da listagem dos nomes
            Console.WriteLine("\n=================================");
            Console.WriteLine("        LISTAGEM DE NOMES        ");
            Console.WriteLine("=================================");

            for (int i = 0; i < totalNomes; i++)
            {
                Console.WriteLine($"{i + 1,2}. {nomes[i]}");
            }

            Console.WriteLine("=================================");
        }
    }
}
