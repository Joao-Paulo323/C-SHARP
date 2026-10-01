using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_A
    {
        public static void Executar()
        {
            Console.WriteLine("--- EXERCÍCIO A: Vetor de Inteiros ---");

            // 1. Declaração e inicialização do vetor de inteiros
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70 };

            Console.WriteLine("Valores armazenados no vetor:\n");

            // 2. Percorrendo o vetor e imprimindo cada elemento usando foreach
            int indice = 0;
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Elemento na posição [{indice}]: {numero}");
                indice++;
            }
        }
    }
}
