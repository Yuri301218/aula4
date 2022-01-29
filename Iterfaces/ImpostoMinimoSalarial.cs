using System;
namespace Iterfaces
{
    public class ImpostoMinimoSalarial : ICalcularImposto
    {
        public double Calcular(double salario)
        {
            return (salario / 100) * 12;
        }
    }
}
