using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.Menu
{
    internal class Menu
    {
        public static void Executar()
        { 
            bool sair = true;
            while (sair)
            {

            
            int opc;
            Console.WriteLine("==============================");
            Console.WriteLine("Lista de Exercicios numero 6 ");
            Console.WriteLine("==============================");
            Console.WriteLine("Escolha qual atividade deseja executar \n\n" +
                "1 .Atividade A\n" +
                "2 .Atividade B\n" +
                "3 .Atividade C\n" +
                "4 .Atividade D\n" +
                "5 .Atividade E\n" +
                "6 .Atividade F\n" +
                "7 .Atividade G\n" +
                "8 .Atividade H\n" +
                "9 .Atividade I\n" +
                "10 .Atividade J\n" +
                "11 .Encerrar Sistema");
            opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        att.attA.ExecutarA();
                       Thread.Sleep(1000);
                        break;
                        

                    case 2:
                        att.attB.ExecutarB();
                        Thread.Sleep(1000);
                        break;

                    case 3:
                        att.attC.ExecutarC();
                        Thread.Sleep(1000);

                        break;
                    case 4:
                        att.attD.ExecutarD();
                        Thread.Sleep(1000);
                        break;








                    case 11:
                        sair = false;
                        Thread.Sleep(1000);
                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
                        Thread.Sleep(1000);
                        break;




                }
            }
        }
    }
}
