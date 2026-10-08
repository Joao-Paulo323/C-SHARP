using System;

namespace Jornada_POO.veiculo
{
    internal class CarroJoaoEco : Carro
    {
        public int CapacidadeBateria { get; set; }
        public int Autonomia { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n===== CARRO JOÃO ECO =====");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Potência: {potencia} cv");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
            Console.WriteLine($"Bateria: {CapacidadeBateria} kWh");
            Console.WriteLine($"Autonomia: {Autonomia} km");
            Console.WriteLine($"Status: {(ligado ? "Ligado" : "Desligado")}");
        }

        public override void Mover()
        {
            Console.WriteLine($"{nome} está se movimentando de forma silenciosa e econômica.");
        }
    }
}