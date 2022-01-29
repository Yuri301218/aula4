using System;

namespace Heranca
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Rodas { get; set; }
        public int Cilindradas { get; set; }
        public string Material { get; set; }
        public int CV { get; set; }
        public string Combustivel { get; set; }
        public double CapacidadeTransporte { get; set; }

        public virtual void Ligar()
        {
            Console.WriteLine($"O veiculo { Modelo } esta ligado");
        }

        public void Desligar()
        {
            Console.WriteLine($"O veiculo { Modelo } esta desligado");
        }

        public abstract void Frear();
    }
}
