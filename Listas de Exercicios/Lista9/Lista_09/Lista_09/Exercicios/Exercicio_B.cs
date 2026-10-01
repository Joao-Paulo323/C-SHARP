using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_B
    {
        public static void Executar()
        {
            int quantidadeAlunos = 5;

            // Declaração dos vetores para armazenar os dados de cada aluno
            string[] nomes = new string[quantidadeAlunos];
            double[] notas1 = new double[quantidadeAlunos];
            double[] notas2 = new double[quantidadeAlunos];
            double[] medias = new double[quantidadeAlunos];

            // 1. Leitura dos dados dos 5 alunos
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine($"--- Aluno {i + 1} de {quantidadeAlunos} ---");

                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Digite a 1ª nota: ");
                notas1[i] = double.Parse(Console.ReadLine());

                Console.Write("Digite a 2ª nota: ");
                notas2[i] = double.Parse(Console.ReadLine());

                // Cálculo da média do aluno
                medias[i] = (notas1[i] + notas2[i]) / 2.0;

                Console.WriteLine(); // Linha em branco
            }

            // 2. Exibição da listagem final
            Console.WriteLine("=================================================");
            Console.WriteLine("               LISTAGEM DOS ALUNOS               ");
            Console.WriteLine("=================================================");
            Console.WriteLine($"{"NOME",-20} | {"NOTA 1",-8} | {"NOTA 2",-8} | {"MÉDIA",-8}");
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine($"{nomes[i],-20} | {notas1[i],8:F1} | {notas2[i],8:F1} | {medias[i],8:F1}");
            }

            Console.WriteLine("=================================================");
        }
    }
}
