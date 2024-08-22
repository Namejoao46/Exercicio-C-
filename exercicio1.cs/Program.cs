using System;
using System.Globalization;

namespace exercicioFixacao
{
    class Program()
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("\n ------Produtos------\n \n");
            Console.WriteLine(" {0}, cujo Preço é {1}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é {1}", produto2, preco2);

            Console.WriteLine("medida; {0}, {1} anos de idade, codigo {2} e genero;{3}", medida, idade, codigo, genero);

            Console.WriteLine("medida com 8 casa decimais {0:F6}", medida);
            Console.WriteLine("arredondado, tres casas após a virgula {0:F3}", medida);

        }
    }
}