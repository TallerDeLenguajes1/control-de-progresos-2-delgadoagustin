using System;

namespace JuegoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(1984, 6, 3);
            Personaje p1 = new Personaje("nombre", "apodo", fecha);
            Console.WriteLine(p1.Armadura);
            Console.WriteLine(p1.Edad);
            Console.WriteLine(p1.Tipo);

        }
    }
}
