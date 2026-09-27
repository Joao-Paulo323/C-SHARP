using System;
namespace att7
{
    class att7
    {
        static void Main(string[] args)
        {
            double num1, num2, sub;
            Console.WriteLine("Escreva dois numeros e te mostrarei a subtração do segundo numero pelo primeiro");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            sub = num2 - num1;
            Console.WriteLine("A subtração dos seus numeros deu "+sub);
        }
    }
}