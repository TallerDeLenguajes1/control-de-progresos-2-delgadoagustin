using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoConsola
{
    enum max
    {
        maxVelocidad = 10,
        maxDestreza = 5,
        maxFuerza = 10,
        maxNivel = 10,
        maxArmadura = 10,
        maxEdad = 300,
        maxSalud = 100

    }
    class Personaje
    {
        int velocidad, destreza, fuerza, nivel, armadura;
        string tipo, nombre, apodo;
        DateTime fecNac;
        int salud;
    }
}
