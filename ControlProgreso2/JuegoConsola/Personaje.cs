using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoConsola
{
    public enum Max
    {
        maxVelocidad = 10,
        maxDestreza = 5,
        maxFuerza = 10,
        maxNivel = 10,
        maxArmadura = 10,
        maxEdad = 300,
        maxSalud = 100
    }

    //string[] Tipos = { "Guerrero", "Mago", "Arquero" };
    public class Personaje
    {
        int velocidad, destreza, fuerza, nivel, armadura;
        string tipo, nombre, apodo;
        DateTime fecNac;
        int salud;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FecNac { get => fecNac; set => fecNac = value; }
        public int Salud { get => salud; set => salud = value; }

        public Personaje(string name, string nick)
        {
            Random valoresAleatorios = new Random();
            Velocidad = valoresAleatorios.Next((int)Max.maxVelocidad);
            Fuerza = valoresAleatorios.Next((int)Max.maxFuerza);
            Destreza = valoresAleatorios.Next((int)Max.maxDestreza);
            Nivel = valoresAleatorios.Next((int)Max.maxNivel);
            Armadura = valoresAleatorios.Next((int)Max.maxArmadura);
            Salud = valoresAleatorios.Next((int)Max.maxSalud);
            //Tipo = 'asd';
            Nombre = name;
            Apodo = nick;

            int añorandom = DateTime.Now.Year - valoresAleatorios.Next((int)Max.maxEdad);
            FecNac = new DateTime(añorandom, (int)valoresAleatorios.Next(1, 12), (int)valoresAleatorios.Next(1, 30));
        }
    }
}
