using System;
namespace att4
{
    class att4
    {
        static void Main(string[] args)
        {
            double num1, quad;
            Console.WriteLine("Escreva um numero e mostraremos o seu numero ao quadrado");
            num1 = double.Parse(Console.ReadLine());
            quad = num1 * num1;
            Console.WriteLine("O quadrado do seu numero é " + quad);
        }
    }
}