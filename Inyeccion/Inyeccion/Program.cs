using System;
using Interfaz;
using Personaje;
using Logica;
using Acciones;
using Ninject;

namespace Inyeccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resident evil...");
            var opcionUsuario = 0;
            var kernel = new StandardKernel();

            Console.WriteLine("Escoje tu personaje");
            Console.WriteLine("1.- Leon");
            Console.WriteLine("2.- Ada");
            Console.WriteLine("3.- Claire");
            Console.WriteLine("4.- Chris");
            opcionUsuario = int.Parse(Console.ReadLine());

            if (opcionUsuario == 1)
            {
                personaje personaje1 = new personaje("Leon", "Comisaria");
                kernel.Bind<IMapa>().To<Trampas>();
                var jugador1 = kernel.Get<ResidentEvil>();
                jugador1.EjecucionTomar(personaje1);
            }
            if (opcionUsuario == 2)
            {
                personaje personaje2 = new personaje("Ada", "Central de Inteligencia");
                kernel.Bind<IMapa>().To<Trampas>();
                var jugador2 = kernel.Get<ResidentEvil>();
                jugador2.EjecucionTomar(personaje2);
            }
            if (opcionUsuario == 3)
            {
                personaje personaje3 = new personaje("Claire", "Biblioteca");
                kernel.Bind<IMapa>().To<Trampas>();
                var jugador3 = kernel.Get<ResidentEvil>();
                jugador3.EjecucionTomar(personaje3);
            }
            if (opcionUsuario == 4)
            {
                personaje personaje4 = new personaje("Chris", "Casa abandonada");
                kernel.Bind<IMapa>().To<Trampas>();
                var jugador4 = kernel.Get<ResidentEvil>();
                jugador4.EjecucionTomar(personaje4);
            }

        }

    }
}


