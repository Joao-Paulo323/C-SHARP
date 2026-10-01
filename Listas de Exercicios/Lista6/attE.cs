using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.att
{
    internal class attE
    {
        public static void ExecutarE()
        {
            Console.Clear(); 

            Console.WriteLine("Escolha uma das opções \n" +
                "1.O console ira dizer Hello Word\n" +
                "2.O console ira falar um numero aleatorio");
            int opc = int.Parse(Console.ReadLine());
            switch(opc){
                case 1:
                    Console.WriteLine("Hello Word");
                    break;
                    case 2:
                    Random random = new Random();
                    int num = random.Next();
                    Console.WriteLine("O seu numero aleatorio é : "+num);
                    break;
            }



        }
    }
}
