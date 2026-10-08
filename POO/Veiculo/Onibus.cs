using System;

namespace Jornada_POO.veiculo
{
    internal class Onibus : Veiculo
    {
        public int QuantidadePassageiros { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n===== ÔNIBUS JOÃO =====");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Motor: {motor}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Potência: {potencia} cv");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Quantidade de passageiros: {QuantidadePassageiros}");
            Console.WriteLine($"Status: {(ligado ? "Ligado" : "Desligado")}");
        }

        public override void Mover()
        {
            Console.WriteLine($"{nome} está transportando passageiros pelas ruas.");
        }
    }
}