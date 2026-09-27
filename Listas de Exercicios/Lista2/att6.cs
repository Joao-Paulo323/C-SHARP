using System;
namespace att6
{
    class att6
    {
        static void Main(string[] args)
        {
            double num1, raiz, tt;
            raiz = 0;
            Console.WriteLine("Digite um numero e te mostraremos a raiz quadrada do seu numero ");
            num1 = double.Parse(Console.ReadLine());
                while (raiz * raiz != num1 && raiz < 1000000) {
                raiz = raiz + 0.1;

            }
            if (raiz * raiz == num1)
            {
                Console.WriteLine("A raiz do seu numero é " + raiz);
            }
            else
            {
                Console.WriteLine("O seu numero não tem raiz");
            } 
        }
    }
}