using System;
namespace Lista_09
{
    class program
    {
        public static void Main(string[] args)
        {
            string continuar = " ";
            while (continuar != "sim")
            {
                Console.Clear();
                MenuPrincipal.Menu.Executar();
                Console.WriteLine("Voce deseja sair?");
                continuar = Console.ReadLine();
            }
        }
    }
}