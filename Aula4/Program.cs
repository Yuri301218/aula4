using System;
using Aula4.Classes;

namespace Aula4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao nosso programa de testes de classes");

            Console.WriteLine("Criando os animais");

            Animal leao = new Animal("Roxo");
            leao.Especie = "Leão";
            leao.Cor = "Azul";
            leao.DefinirComprimento(2);
            leao.Peso = 50;
            leao.Altura = 1;
            leao.Olhos = 3;
         
            leao.Habitat = "Savana";

            Console.WriteLine($"{ leao.Especie } com cor dos olhos { leao.CorOlhos }");

            Animal baleia = new Animal("");
            baleia.Especie = "Baleia";
            baleia.Cor = "Rosa";
            baleia.DefinirComprimento(200);
            baleia.Peso = 2000;
            baleia.Altura = 40;
            baleia.Olhos = 5;
            baleia.Habitat = "Ceu";
            Console.WriteLine($"{ baleia.Especie } com cor dos olhos { baleia.CorOlhos }");

            baleia.Comer("Passarinhos");
            leao.Comer("Pessoas");

            baleia.Locomover("Angeloni");
            leao.Locomover("Angeloni");

            baleia.Comunicar(leao);

        }
    }
}
