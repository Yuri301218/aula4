using System;

namespace Iterfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de calculo de impostos");
            Console.WriteLine("Informe o seu salário");

            double salario = Convert.ToDouble(Console.ReadLine());

            ICalcularImposto calculoImposto = CalculoImpostoFabrica.Criar(salario);

            var resultado  = calculoImposto.Calcular(salario);
            Console.WriteLine($"O valor de imposto a ser pago é { resultado }");
        }
    }
}
