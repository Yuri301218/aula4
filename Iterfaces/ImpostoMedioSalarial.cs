using System;
namespace Iterfaces
{
    public class ImpostoMedioSalarial : ICalcularImposto
    {
        public double Calcular(double salario)
        {
            return (salario / 100) * 22;
        }
    }
}
