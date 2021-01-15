using System;
using Personaje;
using Interfaz;

namespace Acciones
{
    public class Trampas : IMapa
    {
        public bool tomar(personaje personaje)
        {
            Console.WriteLine("Nuestro sobreviviente {0} ah tomado el camino de la {1}", personaje.Nombre, personaje.Camino);
            return true;
        }
    }
}
