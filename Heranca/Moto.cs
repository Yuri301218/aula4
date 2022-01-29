using System;
namespace Heranca
{
    public class Moto : Veiculo
    {
        public void Empinar()
        {
            Console.WriteLine($"A moto { base.Modelo } esta empinando BOLOLOLOLOLO HAHA");
        }

      
        public void Empinar(string nome)
        {
            Console.WriteLine($"O { nome } esta empinando a  moto { base.Modelo } esta empinando");
        }

        public void Empinar(string nome, string passageiro)
        {
            Console.WriteLine($"A moto { base.Modelo } esta sendo empinada por { nome } e { passageiro}");
        }

        public override void Frear()
        {
            Console.WriteLine($"O { base.Modelo } esta freando");
        }
    }
}
