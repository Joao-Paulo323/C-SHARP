using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_D
    {
        public static void Executar()
        {
            // 1. Declaração e inicialização do vetor de inteiros
            int[] numeros = { 15, 42, 8, 99, 23, 67, 4 };

            // 2. Assume que o primeiro elemento é o maior
            int maior = numeros[0];

            // 3. Percorre o vetor comparando com o maior atual
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            // Exibição do resultado
            Console.WriteLine("Valores do vetor: " + string.Join(", ", numeros));
            Console.WriteLine($"\nO maior valor encontrado é: {maior}");
        }
    }
}
