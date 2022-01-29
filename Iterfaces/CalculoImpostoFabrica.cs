using System;
namespace Iterfaces
{
    public static class CalculoImpostoFabrica
    {

        public static ICalcularImposto Criar(double salario)
        {
            if (salario <= 5000)
                return new ImpostoMinimoSalarial();
            else if (salario <= 7500)
                return new ImpostoMedioSalarial();
            else
                return new ImpostoTetoSalarial();
        }
    }
}
