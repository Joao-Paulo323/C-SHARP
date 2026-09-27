
using System.Security.Principal;
namespace att10
{
    class att10
    {
        static void Main(string[] args)
        {
            double num1, rest;
            Console.WriteLine("Escreva um numero e te mostrarei o resto da divisão desse numero por 2 ");
            num1 = double.Parse(Console.ReadLine());
            rest = num1 % 2;
            Console.WriteLine("O resto da divisão desse numero é " + rest);

        }
    }
}