
using System;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Jornada_POO.veiculo
{
    internal class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n===== INFORMAÇÕES DO CARRO =====");

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Potência: {potencia} cv");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
        }
 public override void Mover()
        {
            Console.WriteLine("O carro está se movimentando pelas ruas.");
        }

        }
    }



