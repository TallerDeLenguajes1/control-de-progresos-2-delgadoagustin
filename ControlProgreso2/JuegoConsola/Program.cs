using System;

namespace JuegoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Random valoresAleatorios = new Random();
            Console.WriteLine(valoresAleatorios.Next((int)Max.maxArmadura));
            
        }
    }
}
