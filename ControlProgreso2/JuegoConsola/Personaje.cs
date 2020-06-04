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
        maxSalud = 100,
        MDP = 50000
    }

    enum tipos
    {
        Guerrero,
        Mago,
        Arquero
    }
    public class Personaje
    {
        int velocidad, destreza, fuerza, nivel, armadura, salud, edad;
        string tipo, nombre, apodo;
        DateTime fecNac;

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
        public int Edad { get => edad; set => edad = value; }

        public Personaje(string name, string nick, DateTime date)
        {
            Random valoresAleatorios = new Random();
            Velocidad = valoresAleatorios.Next((int)Max.maxVelocidad);
            Fuerza = valoresAleatorios.Next((int)Max.maxFuerza);
            Destreza = valoresAleatorios.Next((int)Max.maxDestreza);
            Nivel = valoresAleatorios.Next((int)Max.maxNivel);
            Armadura = valoresAleatorios.Next((int)Max.maxArmadura);
            Salud = valoresAleatorios.Next((int)Max.maxSalud);
            Tipo = Enum.GetName(typeof(tipos), valoresAleatorios.Next(3));
            Nombre = name;
            Apodo = nick;
            FecNac = date;
            Edad = DateTime.Now.Year - FecNac.Year;
        }

        void Ataque(Personaje Rival)
        {
            Random gen = new Random();
            int PD = Destreza * Fuerza * Nivel;
            int ED = gen.Next(100) + 1;
            int VA = PD * ED;
            int PDEF = Rival.Armadura * Rival.Velocidad;
            int DM = ((VA * ED) - PDEF / (int)Max.MDP) * 100;
            Rival.Salud -= DM;
        }
    }
}
