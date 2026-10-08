using System;

namespace Jornada_POO.veiculo
{
    internal class CarroJoaoSUV : Carro
    {
        public double CapacidadeCarga { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n===== CARRO JOÃO SUV =====");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Potência: {potencia} cv");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
            Console.WriteLine($"Capacidade de carga: {CapacidadeCarga} kg");
            Console.WriteLine($"Status: {(ligado ? "Ligado" : "Desligado")}");
        }

        public override void Mover()
        {
            Console.WriteLine($"{nome} está se movimentando com segurança e estabilidade.");
        }
    }
}