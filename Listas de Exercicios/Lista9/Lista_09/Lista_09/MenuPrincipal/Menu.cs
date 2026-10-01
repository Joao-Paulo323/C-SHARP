using Lista_09.Exercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09.MenuPrincipal
{
    internal class Menu
    {
        public static void Executar()
        {

            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("             Menu da Lista_05               ");
            Console.WriteLine("============================================");
            Console.WriteLine("1. Para ver exercicio letra (A)             ");
            Console.WriteLine("2. Para ver exercicio letra (B)             ");
            Console.WriteLine("3. Para ver exercicio letra (C)             ");
            Console.WriteLine("4. Para ver exercicio letra (D)             ");
            Console.WriteLine("5. Para ver exercicio letra (E)             ");
            Console.WriteLine("6. Para ver exercicio letra (F)             ");
            Console.WriteLine("7. Para ver exercicio letra (G)             ");
            Console.WriteLine("8. Para ver exercicio letra (H)             ");
            Console.WriteLine("9. Para ver exercicio letra (I)             ");
            Console.WriteLine("10. Para ver exercicio letra (J)\n" +
                "Pressione 0 para Sair.            ");

            Console.WriteLine("============================================");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Exercicio_A.Executar();
                    break;
                case 2:
                    Exercicio_B.Executar();
                    break;
                case 3:
                    Exercicio_C.Executar();
                    break;
                case 4:
                    Exercicio_D.Executar();
                    break;
                case 5:
                    Exercicio_E.Executar();
                    break;
                case 6:
                    Exercicio_F.Executar();
                    break;
                case 7:
                    Exercicio_G.Executar();
                    break;
                case 8:
                    Exercicio_H.Executar();
                    break;
                case 9:
                    Exercicio_I.Executar();
                    break;
                case 10:
                    Exercicio_J.Executar();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção invalida.");
                    break;
            }
        }
    }
}
