using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.att
{
    internal class attF
    {
        public static void ExecutarF()

        {
            Console.Clear();
            Console.WriteLine("Insira um numero inteiro e informarei sua caracteristica");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("eu numeo e Positivo");
            }
            else if (num == 0)
            {
                Console.WriteLine("Seu numero e igual a 0");
            }
            else { Console.WriteLine("Seu numero e negativo"); 
            
            }


        }
    }
}
