using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Lista_06.att
{
    internal class attH
    {
        public static void ExecutarH()
        {
            Console.Clear();
            Console.WriteLine("Digite uma letra e informarei se e consoante ou vogal ");
            string letra = Console.ReadLine();
            if(string.Equals(letra, "A", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(letra, "E", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(letra, "I", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(letra, "O", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(letra, "U", StringComparison.OrdinalIgnoreCase))
{
                Console.WriteLine("Sua letra é vogal");
            }
            else
            {
                Console.WriteLine("Sua letra e consoante");
            }

        }
    }
}
