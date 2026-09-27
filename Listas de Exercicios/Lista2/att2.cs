using System;
namespace att2
{
    class att2
    {
        static void Main(string[] args)
        {
            double num1, dobro;
            Console.WriteLine("Digite um numero e mostrarei seu dobro");
            num1 = double.Parse(Console.ReadLine());
            dobro = num1 * 2;
            Console.WriteLine("O dobro do seu numero é "+dobro);

        }
    }
}






