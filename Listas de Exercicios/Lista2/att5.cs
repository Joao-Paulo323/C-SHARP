using System;
namespace att5
{
    class att5
    {
        static void Main(string[] args)
        {
            double num1, num2,divisao;
            Console.WriteLine("Escreva dois numeros e mostraremo a divisão entre eles");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            divisao = num1 / num2;
            Console.WriteLine("A divisão entre seus dois numeros são " + divisao);
        }
    }
}