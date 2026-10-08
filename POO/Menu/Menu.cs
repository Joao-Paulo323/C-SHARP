using Jornada_POO.veiculo;
using System;
using System.Collections.Generic;

namespace Jornada_POO.Menu
{
    internal class Menu
    {
        public static void Executar()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine("       JORNADA POO - JOÃO");
                Console.WriteLine("==================================");
                Console.WriteLine("1 - Criar Carro");
                Console.WriteLine("2 - Criar Carro Sports");
                Console.WriteLine("3 - Criar Carro SUV");
                Console.WriteLine("4 - Criar Carro Eco");
                Console.WriteLine("5 - Criar Ônibus");
                Console.WriteLine("6 - Criar Caminhão");
                Console.WriteLine("7 - Criar Moto");
                Console.WriteLine("8 - Exibir veículos");
                Console.WriteLine("9 - Ligar veículo");
                Console.WriteLine("10 - Desligar veículo");
                Console.WriteLine("11 - Mover veículos");
                Console.WriteLine("12 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        CriarCarro(veiculos);
                        break;

                    case "2":
                        Console.Clear();
                        CriarCarroSports(veiculos);
                        break;

                    case "3":
                        Console.Clear();
                        CriarCarroSUV(veiculos);
                        break;

                    case "4":
                        Console.Clear();
                        CriarCarroEco(veiculos);
                        break;

                    case "5":
                        Console.Clear();
                        CriarOnibus(veiculos);
                        break;

                    case "6":
                        Console.Clear();
                        CriarCaminhao(veiculos);
                        break;

                    case "7":
                        Console.Clear();
                        CriarMoto(veiculos);
                        break;

                    case "8":
                        Console.Clear();
                        ExibirVeiculos(veiculos);
                        break;

                    case "9":
                        Console.Clear();
                        AlterarEstado(veiculos, true);
                        break;

                    case "10":
                        Console.Clear();
                        AlterarEstado(veiculos, false);
                        break;

                    case "11":
                        Console.Clear();
                        MoverVeiculos(veiculos);
                        break;

                    case "12":
                        Console.Clear();
                        sair = true;
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void CriarCarro(List<Veiculo> veiculos)
        {
            Carro carro = new Carro();

            PreencherDados(carro);

            Console.Write("Número de portas: ");
            carro.NumeroPortas = int.Parse(Console.ReadLine());

            veiculos.Add(carro);

            Console.WriteLine("Carro cadastrado com sucesso!");
        }

        static void CriarCarroSports(List<Veiculo> veiculos)
        {
            CarroJoaoSports carro = new CarroJoaoSports();

            PreencherDados(carro);

            Console.Write("Número de portas: ");
            carro.NumeroPortas = int.Parse(Console.ReadLine());

            Console.Write("Velocidade máxima: ");
            carro.VelocidadeMaxima = double.Parse(Console.ReadLine());

            veiculos.Add(carro);

            Console.WriteLine("Carro Sports cadastrado com sucesso!");
        }

        static void CriarCarroSUV(List<Veiculo> veiculos)
        {
            CarroJoaoSUV carro = new CarroJoaoSUV();

            PreencherDados(carro);

            Console.Write("Número de portas: ");
            carro.NumeroPortas = int.Parse(Console.ReadLine());

            Console.Write("Capacidade de carga em kg: ");
            carro.CapacidadeCarga = double.Parse(Console.ReadLine());

            veiculos.Add(carro);

            Console.WriteLine("Carro SUV cadastrado com sucesso!");
        }

        static void CriarCarroEco(List<Veiculo> veiculos)
        {
            CarroJoaoEco carro = new CarroJoaoEco();

            PreencherDados(carro);

            Console.Write("Número de portas: ");
            carro.NumeroPortas = int.Parse(Console.ReadLine());

            Console.Write("Capacidade da bateria em kWh: ");
            carro.CapacidadeBateria = int.Parse(Console.ReadLine());

            Console.Write("Autonomia em km: ");
            carro.Autonomia = int.Parse(Console.ReadLine());

            veiculos.Add(carro);

            Console.WriteLine("Carro Eco cadastrado com sucesso!");
        }

        static void CriarOnibus(List<Veiculo> veiculos)
        {
            Onibus onibus = new Onibus();

            PreencherDados(onibus);

            Console.Write("Quantidade de passageiros: ");
            onibus.QuantidadePassageiros = int.Parse(Console.ReadLine());

            veiculos.Add(onibus);

            Console.WriteLine("Ônibus cadastrado com sucesso!");
        }

        static void CriarCaminhao(List<Veiculo> veiculos)
        {
            Caminhao caminhao = new Caminhao();

            PreencherDados(caminhao);

            Console.Write("Capacidade de carga em toneladas: ");
            caminhao.CapacidadeCarga = double.Parse(Console.ReadLine());

            veiculos.Add(caminhao);

            Console.WriteLine("Caminhão cadastrado com sucesso!");
        }

        static void CriarMoto(List<Veiculo> veiculos)
        {
            Moto moto = new Moto();

            PreencherDados(moto);

            Console.Write("Cilindradas: ");
            moto.Cilindradas = int.Parse(Console.ReadLine());

            veiculos.Add(moto);

            Console.WriteLine("Moto cadastrada com sucesso!");
        }

        static void PreencherDados(Veiculo veiculo)
        {
            Console.Write("Nome: ");
            veiculo.nome = Console.ReadLine();

            Console.Write("Marca: ");
            veiculo.marca = Console.ReadLine();

            Console.Write("Motor: ");
            veiculo.motor = Console.ReadLine();

            Console.Write("Tipo: ");
            veiculo.tipo = Console.ReadLine();

            Console.Write("Ano: ");
            veiculo.ano = int.Parse(Console.ReadLine());

            Console.Write("Cor: ");
            veiculo.cor = Console.ReadLine();

            Console.Write("Potência: ");
            veiculo.potencia = double.Parse(Console.ReadLine());
        }

        static void ExibirVeiculos(List<Veiculo> veiculos)
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo cadastrado.");
                return;
            }

            Console.WriteLine("\n===== VEÍCULOS CADASTRADOS =====");

            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"\nVeículo {i + 1}:");
                veiculos[i].ExibirInformacoes();
            }
        }

        static void AlterarEstado(List<Veiculo> veiculos, bool ligar)
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo cadastrado.");
                return;
            }

            Console.WriteLine("\n===== VEÍCULOS =====");

            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {veiculos[i].nome}");
            }

            Console.Write("Escolha o veículo: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > veiculos.Count)
            {
                Console.WriteLine("Veículo inválido.");
                return;
            }

            Veiculo veiculo = veiculos[escolha - 1];

            if (ligar)
            {
                veiculo.Ligar();
            }
            else
            {
                veiculo.Desligar();
            }
        }

        static void MoverVeiculos(List<Veiculo> veiculos)
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo cadastrado.");
                return;
            }

            Console.WriteLine("\n===== MOVIMENTAÇÃO DOS VEÍCULOS =====");

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.Mover();
            }
        }
    }
}