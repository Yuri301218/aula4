using System;

namespace Aula4.Classes
{
    public class Animal
    {
        public string Especie { get; set; }
        public string Cor { get; set; }
        public double Comprimento { get; private set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Olhos { get; set; }
        public string CorOlhos { get; private set; }
        public string Habitat { get; set; }

        public Animal(string corDosOlhos)
        {
            if (corDosOlhos != "")
                CorOlhos = corDosOlhos;
            else
                CorOlhos = "Castanho";
        }

        public void DefinirComprimento(double comprimento)
        {
            if (comprimento <= 3800 && comprimento > 0)
                Comprimento = comprimento;
            else
                Console.WriteLine("Voce informou um comprimento invalido");

        }

        public void Comer(string alimento)
        {
            Console.WriteLine($"O animal { Especie } esta comendo o alimento { alimento }");
        }

        public void Locomover(string destino)
        {
            Console.WriteLine($"O animal { Especie } esta se locomovendo para { destino }");
        }

        public void Comunicar(Animal animal)
        {
            Console.WriteLine($"O animal { Especie } esta conversando com { animal.Especie }");
        }
    }
}
