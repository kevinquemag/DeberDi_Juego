using Personaje;
using Interfaz;

namespace Logica
{
    public class ResidentEvil
    {
        IMapa Camino;

        public ResidentEvil(IMapa Camino) 
        {
            this.Camino = Camino;
        }
        public void EjecucionTomar(personaje personaje)
        {
            Camino.tomar(personaje); 
        }
    }
}
