using System;

namespace Jornada_POO.veiculo
{
    internal class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n===== MOTO JOÃO =====");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Potência: {potencia} cv");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Cilindradas: {Cilindradas} cc");
            Console.WriteLine($"Status: {(ligado ? "Ligado" : "Desligado")}");
        }

        public override void Mover()
        {
            Console.WriteLine($"{nome} está se movimentando rapidamente pela estrada.");
        }
    }
}