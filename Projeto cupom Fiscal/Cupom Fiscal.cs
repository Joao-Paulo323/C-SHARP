namespace Cupom_Fiscal
{
    class Menu
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("============= SIMULADOR DE CUPOM FISCAL =============\n" +
                "Digite abaixo quantos produtos deseja adicionar no cupom fiscal");

            //Variaveis e quantidade de produtos

            int qnt;
            while ((int.TryParse(Console.ReadLine(), out qnt) == false))
            {
                Console.WriteLine("Numero de Produtos invalidos digite um numero valido");
            }
            int loop = 0;
            double total = 0, desc, taxa, cupom;
            string[] Pdr = new string[qnt];
            double[] Vlr = new double[qnt];
            double[] Parcela = new double[2];
            double[] Vip = new double[2];
            DateTime tempo = DateTime.Now;
            string resp;

            // Verificação de cliente VIP

            Console.WriteLine("Você e um cliente VIP do nosso estabelecimento ? (Sim | Nao) ");
            resp = Console.ReadLine();
            while (!string.Equals(resp, "Sim", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(resp, "Nao", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Resposta invalida digite uma resposta valida");
                resp = Console.ReadLine();
            }
            if (string.Equals(resp, "Sim", StringComparison.OrdinalIgnoreCase))
            {
                Vip[0] = 0.05;
                Console.WriteLine("No valor final você recebera um pequeno desconto");
            }
            else
            {
                Vip[0] = 0;
                Console.WriteLine("No final da compra seu valor não recebera o desconto de VIP");
            }


            //Nome e valores dos produtos

            while (loop < qnt)
            {
                Console.WriteLine("Digite o nome do seu " + (loop + 1) + "° produto");
                Pdr[loop] = Console.ReadLine();
                Console.WriteLine("Digite o valor do seu " + (loop + 1) + "° produto");


                while ((double.TryParse(Console.ReadLine(), out Vlr[loop]) == false))
                {
                    Console.WriteLine("Valor invalido por favor digite um valor valido");
                }
                loop++;
            }

            //Desconto

            Console.WriteLine("Digite o valor do desconto dos produtos abaixo em porcentagem  (0 - 100)");

            while ((double.TryParse(Console.ReadLine(), out desc) == false) || desc < 0 || desc > 100)
            {
                Console.WriteLine("Valor invalido digite um valor valido");
            }

            //Valor final com desconto

            for (int i = 0; i < Vlr.Length; i++)
            {
                total = total + Vlr[i];
            }

            desc = total - (total * (desc / 100));

            //Taxa de Imposto

            Console.WriteLine("Você deseja adicionar uma taxa de imposto sobre seu valor final (Sim ou Não)");
            resp = Console.ReadLine();
            while (!string.Equals(resp, "sim", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(resp, "nao", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite uma opção valida");
                resp = Console.ReadLine();
            }
            if (string.Equals(resp, "sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite o valor da taxa em porcentagem");
                while ((double.TryParse(Console.ReadLine(), out taxa) == false) || taxa < 0 || taxa > 100)
                {
                    Console.WriteLine("Valor invalido digite um valor valido");
                }
                taxa = desc + (desc * (taxa / 100));
            }
            else
            {
                taxa = desc;
            }


            //CODIGO DE CUPOM

            Console.WriteLine("Você tem algum codigo de cupom de desconto que deseja aplicar (Sim | Nao)");
            resp = Console.ReadLine();
            while (!string.Equals(resp, "Sim", StringComparison.OrdinalIgnoreCase) &&
            !string.Equals(resp, "Nao", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite uma opção valida");
                resp = Console.ReadLine();
            }
            if (string.Equals(resp, "Sim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite o codigo do cupom de desconto\n" +
                    "Caso não tenha um pode usar esse codigo de primeira compra (PROMO5)");
                resp = Console.ReadLine();

                if (string.Equals(resp, "PROMO5", StringComparison.OrdinalIgnoreCase))
                {
                    cupom = taxa - (total * 0.05);
                }
                else
                {
                    cupom = taxa;
                }
            }
            else
            {
                cupom = taxa;
            }
 
            //Desconto VIP
            if (Vip[0] > 0)
            {
                Vip[1] = cupom - (cupom * Vip[0]);
            }
            else if ( Vip[0] ==0) {
                Vip[1] = cupom;
            }


            //Parcelas

            Console.WriteLine("Você deseja parcelar a sua compra ou pagar a vista? (parcela || vista)");
            while (!string.Equals(resp, "Parcela", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(resp, "Vista", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite uma opção valida");
                resp = Console.ReadLine();
            }
            if (string.Equals(resp, "parcela", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite quantas parcelas voce deseja fazer (2-12)");
                while ((double.TryParse(Console.ReadLine(), out Parcela[0]) == false) ||
                    Parcela[0] < 2 ||
                    Parcela[0] > 12 ||
                    Parcela[0] % 1 != 0)
                {
                    Console.WriteLine("Numero de parcelas invalido digite um numero valido");
                }
                Parcela[1] = cupom / Parcela[0];



                //Cupom fiscal

                Console.WriteLine("===== SEU CUPOM FISCAL FOI CRIADO =====");
                for(int i = 0; i < Pdr.Length; i++)
                {
                    Console.WriteLine($"{Pdr[i]} - R$ {Vlr[i]:F2}");
                }
                Console.WriteLine($"Seu desconto foi de R$ {desc:F2}" +
                    $"Você teve uma taxa de R$ {taxa:F2}\n" +
                    $"Seu desconto com o cupom foi de R$ {cupom:F2}\n" +
                    $"O desconto para Vips ficou em R$ {Vip[1]}\n" +
                    $"Parcelado em " + Parcela[0]+"X\n" +
                    $"Com cada parcela no valor de R${Parcela[1]}");

            }
        } 
    }
}