using System;

namespace Jornada_POO.veiculo
{
    internal class CarroJoaoSports : Carro
    {
        public double VelocidadeMaxima { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n===== CARRO JOÃO SPORTS =====");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Potência: {potencia} cv");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Número de portas: {NumeroPortas}");
            Console.WriteLine($"Velocidade máxima: {VelocidadeMaxima} km/h");
            Console.WriteLine($"Status: {(ligado ? "Ligado" : "Desligado")}");
        }

        public override void Mover()
        {
            Console.WriteLine($"{nome} está acelerando rapidamente na pista!");
        }
    }
}