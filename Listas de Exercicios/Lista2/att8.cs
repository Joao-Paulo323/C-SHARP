using System;
using System.Security.Principal;
namespace att8
{
    class att8
    {
        static void Main(string[] args)
        {
            double num1, loop=0;
            Console.WriteLine("Escreva um numero inteiro e falarei seu valor absoluto ");
            num1 = double.Parse(Console.ReadLine());
            while (num1 != 0){
                if (num1 < 0)
                {
                    num1 = num1 + 1;
                    loop = loop + 1;
                }
                else if (num1 > 0)
                {
                    num1 = num1 - 1;
                    loop = loop + 1;
                }
            }
            Console.WriteLine("O seu valor absoluto é "+loop);



          
        }
    }
}