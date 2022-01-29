using System;
namespace Heranca
{
    public class Carro : Veiculo
    {
        public void Drift()
        {
            Console.WriteLine($"O carro { base.Modelo } esta fazendo drift");
        }

        public override void Frear()
        {
            Console.WriteLine($"O carro { base.Modelo } esta freando com freios ABS");
        }

        public override void Ligar()
        {
            Console.WriteLine("Preparando sistema de igniçao e injeçao");
            Console.WriteLine($"Ligando o Carro { base.Modelo} ");
            Console.WriteLine($"{ base.Modelo } Ligado");
        }
    }
}
