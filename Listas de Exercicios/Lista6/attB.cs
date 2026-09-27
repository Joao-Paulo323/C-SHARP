using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.att
{
    internal class attB
    {
        public static void ExecutarB()
        {
            Console.Clear();
            Console.WriteLine("Digite duas datas diferentes e falarei a diferencça de dias entre eles");
            Console.WriteLine("Digite a primeira data");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda data");
            DateTime data2 = DateTime.Parse(Console.ReadLine());
            TimeSpan diferenca = data2 - data;
            Console.WriteLine("A diferença de dias e de "+diferenca.Days);
        }   

    }
}
