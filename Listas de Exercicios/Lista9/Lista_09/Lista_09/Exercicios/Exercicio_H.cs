using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_H
    {
        public static void Executar()
        {
            // 1. Declaração e inicialização do vetor de inteiros
            int[] numeros = { 15, 3, 89, 42, 7, 64, 21 };

            Console.WriteLine("Vetor original: " + string.Join(", ", numeros));

            // 2. Ordena o vetor em ordem crescente primeiro
            Array.Sort(numeros);

            // 3. Inverte a ordem dos elementos para ficar decrescente
            Array.Reverse(numeros);

            // Exibição do resultado
            Console.WriteLine("\nVetor em ordem decrescente: " + string.Join(", ", numeros));
        }
    }
}
