using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.att
{
    internal class attG
    {
        public static void ExecutarG()
        {
            Console.Clear();
           
            Console.WriteLine("Escolha uma cor entre essas tres opções \n" +
                "Vermelho" +
                "\nVerde" +
                "\nAzul");
            string opc = Console.ReadLine();
            while (true)
            {
                if (opc == "Vermelho")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sua cor escolhida foi a vermelha");
                    break;
                }
                else if (opc == "Verde")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sua cor escolhida foi a Verde");
                    break;

                }
                else if (opc == "Azul")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sua cor escolhida foi a Azul");
                    break;

                }
                else
                {
                    Console.WriteLine("Opção invalida tente novamente");
                    opc = Console.ReadLine();
                }
            }



        }
    }
}
