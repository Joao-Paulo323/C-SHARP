using System;

namespace Jornada_POO.veiculo
{
    internal class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n===== CAMINHÃO JOÃO =====");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Potência: {potencia} cv");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Capacidade de carga: {CapacidadeCarga} toneladas");
            Console.WriteLine($"Status: {(ligado ? "Ligado" : "Desligado")}");
        }

        public override void Mover()
        {
            Console.WriteLine($"{nome} está transportando cargas.");
        }
    }
}