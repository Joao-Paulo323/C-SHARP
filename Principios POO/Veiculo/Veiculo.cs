using System;
using System.Collections.Generic;
using System.Text;

namespace Jornada_POO.veiculo
{
    internal abstract class Veiculo
    {
        public string nome { get; set; }
        public string motor { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public double potencia { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }
        public bool ligado { get; private set; }
        public abstract void Mover();
        public void Ligar()
        {
            ligado = true;
            Console.WriteLine("O veiculo está ligado");
        }
        public void Desligar()
        {
            ligado = false;
            Console.WriteLine("O veiculo está Desligado");
        }
        public abstract void ExibirInformacoes();
    }

}
