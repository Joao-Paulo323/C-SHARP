using System;
namespace att3
{
    class att3
    {
        static void Main(string[] args)
        {
            double num1, metade;
            Console.WriteLine("Escreva um numero e mostraremos a metade dele");
            num1 = double.Parse(Console.ReadLine());
            metade = num1 / 2;
            Console.WriteLine("A metade do seu numero é "+metade);
        }
    }
}