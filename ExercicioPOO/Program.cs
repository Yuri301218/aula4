using System;

namespace ExercicioPOO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal[] animais = new Animal[3];
            animais[0] = new Gato();
            animais[1] = new Cachorro();
            animais[2] = new Pato();

            foreach (var animal in animais)
            {
                animal.EmitirSom();
            }

            Console.ReadLine();
        }
    }
}
