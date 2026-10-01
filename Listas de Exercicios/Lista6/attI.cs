using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_06.att
{
    internal class attI
    {
        public static void ExecutarI()
        {
            Console.Clear();
                Console.Write("Digite um número de 1 a 7: ");
                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;

                    case 2:
                        Console.WriteLine("Segunda-feira");
                        break;

                    case 3:
                        Console.WriteLine("Terça-feira");
                        break;

                    case 4:
                        Console.WriteLine("Quarta-feira");
                        break;

                    case 5:
                        Console.WriteLine("Quinta-feira");
                        break;

                    case 6:
                        Console.WriteLine("Sexta-feira");
                        break;

                    case 7:
                        Console.WriteLine("Sábado");
                        break;

                    default:
                        Console.WriteLine("Número inválido! Digite um número de 1 a 7.");
                        break;
                }
            }
        }

    }

 
