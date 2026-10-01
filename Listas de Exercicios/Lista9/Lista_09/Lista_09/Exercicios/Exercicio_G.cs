using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_G
    {
        public static void Executar()
        {
            int tamanho = 5;

            // 1. Definição dos dois vetores base
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];
            int[] vetorSoma = new int[tamanho];

            // Leitura dos dados do Primeiro Vetor
            Console.WriteLine("--- Digite os 5 valores do Primeiro Vetor ---");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Vetor 1 - Posição [{i}]: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            // Leitura dos dados do Segundo Vetor
            Console.WriteLine("\n--- Digite os 5 valores do Segundo Vetor ---");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Vetor 2 - Posição [{i}]: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            // 2. Cálculo do Vetor Soma
            for (int i = 0; i < tamanho; i++)
            {
                vetorSoma[i] = vetor1[i] + vetor2[i];
            }

            // 3. Exibição dos Vetores
            Console.WriteLine("\n==================================");
            Console.WriteLine("Vetor 1:    [" + string.Join(", ", vetor1) + "]");
            Console.WriteLine("Vetor 2:    [" + string.Join(", ", vetor2) + "]");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Vetor Soma: [" + string.Join(", ", vetorSoma) + "]");
            Console.WriteLine("==================================");
        }
    }
}
