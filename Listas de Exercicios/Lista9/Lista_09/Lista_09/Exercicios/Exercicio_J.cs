using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.Exercicios
{
    internal class Exercicio_J
    {
        public static void Executar()
        {
            const int TOTAL_MERCADORIAS = 40;

            // Vetores paralelos para armazenar os dados do estoque
            string[] nomes = new string[TOTAL_MERCADORIAS];
            int[] quantidades = new int[TOTAL_MERCADORIAS];
            double[] precios = new double[TOTAL_MERCADORIAS];

            bool cadastradas = false; // Controle para saber se já houve cadastro
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("              MENU               ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Cadastra mercadorias");
                Console.WriteLine("2. Exibe valor total em mercadorias da empresa");
                Console.WriteLine("3. Sair");
                Console.WriteLine("=================================");
                Console.Write("OPÇÃO: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 0; // Opção inválida se não for número
                }

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"--- CADASTRO DE {TOTAL_MERCADORIAS} MERCADORIAS ---");
                        for (int i = 0; i < TOTAL_MERCADORIAS; i++)
                        {
                            Console.WriteLine($"\nMercadoria {i + 1} de {TOTAL_MERCADORIAS}:");

                            Console.Write("Nome: ");
                            nomes[i] = Console.ReadLine();

                            Console.Write("Quantidade em estoque: ");
                            while (!int.TryParse(Console.ReadLine(), out quantidades[i]) || quantidades[i] < 0)
                            {
                                Console.Write("Quantidade inválida! Digite um número inteiro (>= 0): ");
                            }

                            Console.Write("Preço unitário (R$): ");
                            while (!double.TryParse(Console.ReadLine(), out precios[i]) || precios[i] < 0)
                            {
                                Console.Write("Preço inválido! Digite um valor numérico (>= 0): ");
                            }
                        }

                        cadastradas = true;
                        Console.WriteLine("\nTodas as mercadorias foram cadastradas com sucesso!");
                        break;

                    case 2:
                        if (!cadastradas)
                        {
                            Console.WriteLine("Nenhuma mercadoria foi cadastrada ainda! Escolha a opção 1 primeiro.");
                        }
                        else
                        {
                            double valorTotalEmpresa = 0.0;

                            Console.WriteLine("--- VALOR TOTAL DO ESTOQUE ---");
                            for (int i = 0; i < TOTAL_MERCADORIAS; i++)
                            {
                                double valorSubtotal = quantidades[i] * precios[i];
                                valorTotalEmpresa += valorSubtotal;
                            }

                            Console.WriteLine($"O valor total em mercadorias da empresa é: R$ {valorTotalEmpresa:N2}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saindo do sistema... Até logo!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Escolha 1, 2 ou 3.");
                        break;
                }

                if (opcao != 3)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 3);
        }
    }
}
