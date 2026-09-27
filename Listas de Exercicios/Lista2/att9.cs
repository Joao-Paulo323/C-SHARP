
using System.Security.Principal;
namespace att9
{
    class att9
    {
        static void Main(string[] args)
        {
            double num1,num2,mult;
            Console.WriteLine("Escreva dois numeros e mostrarei a multiplicação entre eles ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            mult = num1 * num2;
            Console.WriteLine("A multiplicação entre os dois numeros é " + mult);

        }
    }
}