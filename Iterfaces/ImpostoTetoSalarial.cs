using System;
namespace Iterfaces
{
    public class ImpostoTetoSalarial : ICalcularImposto
    {
        public double Calcular(double salario)
        {
            return (salario / 100) * 27.5;
        }
    }
}
