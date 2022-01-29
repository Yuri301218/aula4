using System;

namespace Heranca
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fabrica de veiculos da honda");

            var moto = new Moto();
            moto.Modelo = "CB 650f";
            moto.Material = "Metal";
            moto.Cilindradas = 648;
            moto.Ano = 2022;
            moto.CV = 80;
            moto.Rodas = 2;
            moto.Combustivel = "Flex";

            Console.WriteLine($" A moto { moto.Modelo } tem { moto.Cilindradas } cc");

            moto.Frear();
            moto.Ligar();
            moto.Empinar();
            moto.Empinar("Ferraz");
            moto.Empinar("Marcelo", "Fernando");

            var carro = new Carro();

            carro.Modelo = "City 1.5 turbo";
            carro.Material = "Metal";
            carro.Cilindradas = 1500;
            carro.Ano = 2022;
            carro.CV = 300;
            carro.Rodas = 5;
            carro.Combustivel = "Gasolina";

            carro.Frear();
            carro.Ligar();
            carro.Drift();
        }
    }
}
