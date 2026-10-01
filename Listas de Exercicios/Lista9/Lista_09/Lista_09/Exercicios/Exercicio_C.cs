using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_C
    {
        public static void Executar()
        {
            // 1. Declaração e inicialização do vetor com números decimais
            double[] numeros = { 7.5, 8.2, 5.0, 9.4, 6.8, 10.0 };

            // 2. Cálculo da soma utilizando um laço de repetição
            double soma = 0.0;
            foreach (double num in numeros)
            {
                soma += num;
            }

            // 3. Cálculo da média (soma dividida pelo número total de elementos)
            double media = soma / numeros.Length;

            // Exibição dos resultados
            Console.WriteLine("Valores do vetor: " + string.Join(" | ", numeros));
            Console.WriteLine($"Soma total: {soma:F2}");
            Console.WriteLine($"Média dos valores: {media:F2}");
        
        }
    }
}
