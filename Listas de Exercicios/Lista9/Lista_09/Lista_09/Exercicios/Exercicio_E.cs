using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_E
    {
        public static void Executar()
        {
            // 1. Declaração e inicialização do vetor de inteiros
            int[] numeros = { 45, 12, 89, 3, 27, 64, 18 };

            // 2. Assume que o primeiro elemento é o menor
            int menor = numeros[0];

            // 3. Percorre o vetor comparando com o menor atual
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            // Exibição do resultado
            Console.WriteLine("Valores do vetor: " + string.Join(", ", numeros));
            Console.WriteLine($"\nO menor valor encontrado é: {menor}");
        }
    }
}
