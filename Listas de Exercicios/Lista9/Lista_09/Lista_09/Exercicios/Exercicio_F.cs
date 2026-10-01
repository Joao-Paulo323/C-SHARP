using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_F
    {
        public static void Executar()
        {
            const int tamanho = 5;

            // Declaração dos vetores
            int[] vetorA = new int[tamanho];
            int[] vetorB = new int[tamanho];
            int[] vetorSoma = new int[tamanho];

            // 1. Leitura dos elementos do primeiro vetor (Vetor A)
            Console.WriteLine("--- Preenchendo o VETOR A ---");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            // 2. Leitura dos elementos do segundo vetor (Vetor B)
            Console.WriteLine("\n--- Preenchendo o VETOR B ---");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            // 3. Processamento: Gerando o Vetor Soma
            for (int i = 0; i < tamanho; i++)
            {
                vetorSoma[i] = vetorA[i] + vetorB[i];
            }

            // 4. Exibição do resultado
            Console.WriteLine("\n=================================");
            Console.WriteLine("        RESULTADO DA SOMA        ");
            Console.WriteLine("=================================");
            Console.WriteLine("Vetor A:    " + string.Join(" | ", vetorA));
            Console.WriteLine("Vetor B:    " + string.Join(" | ", vetorB));
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Vetor Soma: " + string.Join(" | ", vetorSoma));
            Console.WriteLine("=================================");
        }
    }
}
