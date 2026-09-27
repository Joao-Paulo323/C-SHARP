using System;
using System.Data;
namespace att1
{
    class att1
    {
        static void Main(string[] args)
        {
            double num1,num2,tt;
            Console.WriteLine("Escreva dois numeros e lhe mostrarei a soma deles ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            tt = num1 + num2;
            Console.WriteLine("A soma dos seus numeros é "+tt);
        }
    }
}