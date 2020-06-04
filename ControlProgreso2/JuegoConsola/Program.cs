using System;
using System.Collections.Generic;
using System.Threading;

namespace JuegoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personaje> Lista = new List<Personaje>();
            Random gen = new Random();
            string[] nombres = { "Pedro", "Juan", "Camila", "Gabriel" };
            string[] apodos = { "Bab", "H20", "AnismanLoMataron" };

            int cant = gen.Next(100);

            for (int i = 0; i < cant; i++)
            {
                string nombre = nombres[gen.Next(4)];
                string apodo = apodos[gen.Next(3)];
                DateTime fecha = new DateTime(gen.Next(300)+1720, 6, 3);
                Personaje pj = new Personaje(nombre, apodo, fecha);
                Lista.Add(pj);
            }

            foreach (Personaje pj in Lista)
            {
                Console.WriteLine(pj.Nombre + " " + pj.Apodo + " " + pj.Edad);
            }

        }
    }
}
