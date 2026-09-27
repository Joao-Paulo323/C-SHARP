using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.att
{
    internal class attC
    {
        public static void ExecutarC()
        {
            Console.Clear();
            Console.WriteLine("Digite sua data de nascimento e irei falar sua idade atual ");
            DateTime dataN = DateTime.Parse(Console.ReadLine());
            DateTime data = DateTime.Today;
            int idade = data.Year - dataN.Year;
            if (dataN.Date > data.AddYears(-idade))
            {
                idade--;
            }
            Console.WriteLine("A sua idade e de "+idade);
        }
    }
}
