using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.att
{
    internal class attJ
    {
        public static void ExecutarJ()
        {
            Console.Clear();
            Console.WriteLine("Escolha o tamanho da camiseta:");
            Console.WriteLine("P - Pequena");
            Console.WriteLine("M - Média");
            Console.WriteLine("G - Grande");

            string tamanho = Console.ReadLine();

            switch (tamanho.ToUpper())
            {
                case "P":
                    Console.WriteLine("Preço: R$ 30,00");
                    break;

                case "M":
                    Console.WriteLine("Preço: R$ 35,00");
                    break;

                case "G":
                    Console.WriteLine("Preço: R$ 40,00");
                    break;

                default:
                    Console.WriteLine("Tamanho inválido!");
                    break;
            }

        }
    }
}
