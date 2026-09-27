using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Lista_06.att
{
    internal class attD
    {
    public static void ExecutarD()
        {
            Console.Clear();
            bool feriado = false;
            string nmFeriado = "";
            Console.WriteLine("Digite uma data e informaremos se ela e um feriado nacional (dd/mm/yyyy)");
            DateTime data = DateTime.Parse(Console.ReadLine());
            if (data.Day == 1 && data.Month == 1)
            {
                feriado = true;
                nmFeriado = "Confraternização Universal";
            }
            else if (data.Day == 21 && data.Month == 4)
            {
                feriado=true;
                nmFeriado = "Tiradentes";
            }
            else if (data.Day == 1 && data.Month == 5)
            {
                feriado =true;
                nmFeriado = "Dia do Trabalho";
            }
            else if (data.Day == 7 && data.Month == 9)
            {
                feriado = true;
                nmFeriado = "Independência do Brasil";
            }
            else if (data.Day == 12 && data.Month == 10)
            {
                feriado = true;
                nmFeriado = "Nossa Senhora Aparecida";
            }
            else if (data.Day == 2 && data.Month == 11)
            {
                feriado = true;
                nmFeriado = "Finados";
            }
            else if (data.Day == 15 && data.Month == 11)
            {
                feriado = true;
                nmFeriado = "Proclamação da República";
            }
            else if (data.Day == 20 && data.Month == 11)
            {
                feriado = true;
                nmFeriado = "Dia Nacional de Zumbi e da Consciência Negra";
            }
            else if (data.Day == 25 && data.Month == 12)
            {
                feriado = true;
                nmFeriado = "Natal";
            }
            if (feriado)
            {

                Console.WriteLine("A sua data e um feriado nacional \n" +
                    "Seu feriado é " + nmFeriado);
            }
             else
            {
                Console.WriteLine("Sua data não e um feriado nacional");
            }



        }
    }
}
